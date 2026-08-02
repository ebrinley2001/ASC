using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;
using System.IO;

namespace WixSharp
{
    public class BuildInfo
    {
        public string AppName { get; set; } = "Aelimor Sheet Creator";
        public string ExeName { get; set; } = "ASC.UI.exe";
        public string FullSemVer { get; }
        public string Version { get; }
        public string SourcePath { get; }
        public string IconPath { get; }
        public string LogoPath { get; }
        public string AssemblyPath { get; }

        public BuildInfo(IConfiguration config)
        {
#if DEBUG
            var appSettings = config.GetSection("Debug");
#else
            var appSettings = config.GetSection("Release");
#endif

            AssemblyPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, appSettings["AssemblyPath"]));
            if (!System.IO.File.Exists(AssemblyPath))
            {
                throw new FileNotFoundException(AssemblyPath);
            }
            System.Reflection.Assembly assembly = System.Reflection.Assembly.LoadFile(AssemblyPath);
            FileVersionInfo version = FileVersionInfo.GetVersionInfo(AssemblyPath);

            FullSemVer = version.ProductVersion;
            Version = version.FileVersion;
            SourcePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, appSettings["SourcePath"]));
            IconPath = appSettings["IconPath"];
            LogoPath = appSettings["LogoPath"];
        }
    }
}
