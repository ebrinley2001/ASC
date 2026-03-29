using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using WixSharp;
using WixSharp.Forms;
using File = WixSharp.File;

namespace ASC.Installer
{
    public class Program
    {
        const string BUILD_COMMAND = @"dotnet build ..\ASC.UI\ASC.UI.csproj -c Release --self-contained";
        const string RELEASE_OUTPUT = @"..\ASC.UI\bin\Release\net8.0-windows\win-x64";
        const string STAGING_OUTPUT = @"staging";
        const string APP_NAME = "Aelimor Sheet Creator";
        const string EXE_NAME = "ASC.UI.exe";

        const string PROGRAM_INSTALL_DIR = @"%ProgramFiles64%\ASC";
        const string DATA_INSTALL_DIR = @"%CommonAppData%\ASC";
        const string OUTPUT_FOLDER = "build";

        static void Main()
        {
            string buildDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string stagingDir = Path.Combine(buildDir, STAGING_OUTPUT);

            BuildApp(BUILD_COMMAND, buildDir, stagingDir);

            var project = new ManagedProject(APP_NAME,
                new Dir(PROGRAM_INSTALL_DIR,
                    new Files(Path.Combine(stagingDir, "*.*"))
                ),
                new Dir(DATA_INSTALL_DIR,
                    new DirPermission("Everyone", GenericPermission.All),
                    new File(@"..\Resources\ascdb.db")
                )
            );

            FileVersionInfo info = FileVersionInfo.GetVersionInfo(Path.Combine(stagingDir, EXE_NAME));

            project.Platform = Platform.x64;
            project.GUID = new Guid("f9410119-7271-4c59-a59a-a54bd914e9cc");
            project.Version = new Version(info.FileVersion);
            project.ControlPanelInfo.Manufacturer = "Ethan B";
            project.ControlPanelInfo.Contact = "Ethan B";

            project.ManagedUI = new ManagedUI();
            project.ManagedUI.InstallDialogs
                .Add(Dialogs.Welcome)
                .Add(Dialogs.Licence)
                .Add(Dialogs.InstallDir)
                .Add(Dialogs.Progress)
                .Add(Dialogs.Exit);

            project.ManagedUI.ModifyDialogs
                .Add(Dialogs.MaintenanceType)
                .Add(Dialogs.Features)
                .Add(Dialogs.Progress)
                .Add(Dialogs.Exit);

            var exe = project.ResolveWildCards().FindFile(f => f.Name.EndsWith(EXE_NAME)).First();
            exe.Shortcuts = new[]
                {
                    new FileShortcut($"{APP_NAME}.exe", "%Desktop%")
                };

            string productMsi = project.BuildMsi(Path.Combine(OUTPUT_FOLDER, "ASC Installer.msi"));
        }

        private static void BuildApp(string command, string buildDir, string stagingDir)
        {
            using (Process process = new Process())
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + command;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;

                process.StartInfo = startInfo;
                process.Start();

                string result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                Console.WriteLine(result);
            }

            if (Directory.Exists(RELEASE_OUTPUT))
            {
                Console.WriteLine(buildDir);
                if (Directory.Exists(stagingDir))
                {
                    Directory.Delete(stagingDir, true);
                }
                Directory.Move(RELEASE_OUTPUT, stagingDir);
            }
        }
    }
}