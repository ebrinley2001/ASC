using System;
using System.IO;
using System.Linq;
using System.Net;
using WixSharp;
using WixSharp.Bootstrapper;
using WixSharp.CommonTasks;
using File = WixSharp.File;

namespace ASC.Installer
{
    public class Program
    {
        static void Main()
        {
            const string APP_NAME = "Aelimor Sheet Creator";
            const string INSTALL_DIR = @"%ProgramFiles%\ASC";
            const string EXE_NAME = "ASC.UI.exe";

            const string OUTPUT_FOLDER = "build";

            var project = new ManagedProject(APP_NAME,
                new Dir(INSTALL_DIR,
                    new Files(@"..\ASC.UI\bin\Release\net8.0-windows\*.*"),
                    new File(@"..\Resources\ascdb.db")
                )
            );

            project.Platform = Platform.x64;

            project.ResolveWildCards().FindFile(f => f.Name.EndsWith(EXE_NAME))
               .First()
               .Shortcuts = new[]
                    {
                        new FileShortcut($"{APP_NAME}.exe", "%Desktop%")
                    };

            project.GUID = new Guid("ad39908c-ba52-4073-8ead-248ff3f7c2e9");

            string productMsi = project.BuildMsi(Path.Combine(OUTPUT_FOLDER, "ASC Installer.msi"));

            var bootstrapper = new Bundle(APP_NAME,
                Net8(),
                Net8Desktop(),
                new MsiPackage(productMsi)
            );

            bootstrapper.Include(WixExtension.Util);

            bootstrapper.AddWixFragment("Wix/Bundle",
                new UtilRegistrySearch()
                {
                    Root = RegistryHive.LocalMachine,
                    Key = @"SOFTWARE\dotnet\Setup\InstalledVersions\x64\sharedhost",
                    Value = "Version",
                    Win64 = true,
                    Result = SearchResult.value,
                    Variable = "Net8"
                }
            );

            bootstrapper.AddWixFragment("Wix/Bundle",
                new UtilRegistrySearch()
                {
                    Root = RegistryHive.LocalMachine,
                    Key = @"SOFTWARE\WOW6432Node\dotnet\Setup\InstalledVersions\x64\sharedfx\Microsoft.WindowsDesktop.App",
                    Value = "8.0.24",
                    Win64 = true,
                    Result = SearchResult.exists,
                    Variable = "Net8Desktop"
                }
            );

            bootstrapper.SetVersionFromFile(productMsi);

            bootstrapper.Build(Path.Combine(OUTPUT_FOLDER, "ASC Installer.exe"));
        }

        private static ExePackage Net8Desktop()
        {
            string currentNet8Desktopinstaller =
               @"https://builds.dotnet.microsoft.com/dotnet/WindowsDesktop/8.0.24/windowsdesktop-runtime-8.0.24-win-x64.exe";
            string Net8Installer = "Net8-desktop.exe";
            using (var client = new WebClient())
            {
                client.DownloadFile(currentNet8Desktopinstaller, Net8Installer);
            }
            ExePackage Net8exe = new ExePackage(Net8Installer)
            {
                Compressed = true,
                Vital = true,
                Name = Net8Installer,
                DetectCondition = "Net8Desktop",
                PerMachine = true,
                Permanent = false,
                UninstallArguments = "/uninstall /quiet"
            };

            return Net8exe;
        }

        private static ExePackage Net8()
        {
            string currentNet8installer =
               @"https://builds.dotnet.microsoft.com/dotnet/Sdk/8.0.418/dotnet-sdk-8.0.418-win-x64.exe";
            string Net8Installer = "Net8.exe";
            using (var client = new WebClient())
            {
                client.DownloadFile(currentNet8installer, Net8Installer);
            }
            ExePackage Net8exe = new ExePackage(Net8Installer)
            {
                Compressed = true,
                Vital = true,
                Name = Net8Installer,
                DetectCondition = "Net8 >= \"8.0.0.0\"",
                PerMachine = true,
                Permanent = false,
                UninstallArguments = "/uninstall /quiet"
            };

            return Net8exe;
        }
    }
}