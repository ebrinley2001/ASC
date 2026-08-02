using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using WixSharp;
using WixSharp.Forms;
using File = WixSharp.File;

namespace ASC.Installer
{
    public class Program
    {
        const string PROGRAM_INSTALL_DIR = @"%ProgramFiles64%\ASC";
        const string DATA_INSTALL_DIR = @"%CommonAppData%\ASC";

        static void Main()
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var buildInfo = new BuildInfo(config);

            var project = new ManagedProject(buildInfo.AppName,
                new Dir(PROGRAM_INSTALL_DIR,
                    new Files(Path.Combine(buildInfo.SourcePath, "*.*"))
                ),
                new Dir(DATA_INSTALL_DIR,
                    new DirPermission("Everyone", GenericPermission.All),
                    new File(@"..\..\..\..\Resources\ascdb.db")
                )
            );

            project.Platform = Platform.x64;
            project.GUID = new Guid("f9410119-7271-4c59-a59a-a54bd914e9cc");
            project.Version = new Version(buildInfo.Version);
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

            var exe = project.ResolveWildCards().FindFile(f => f.Name.EndsWith(buildInfo.ExeName)).First();
            exe.Shortcuts = new[]
            {
                new FileShortcut($"{buildInfo.AppName}.exe", "%Desktop%")
            };

            project.BuildMsi($"ASCInstaller-{buildInfo.Version}.msi");
        }
    }
}