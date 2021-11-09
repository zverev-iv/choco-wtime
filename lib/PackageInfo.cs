public class PackageInfo
{
    public string PackageVersion { get; set; }
    public string Package32Url { get; set; }
    public string Package64Url { get; set; }

    #region BuildFolders

    public string BinDir { get => "bin"; }
    public string TempDir { get => "temp"; }

    #endregion

    #region PackageSettings

    public ChocolateyPackSettings PackageSettings
    {
        get => new ChocolateyPackSettings
        {
            //PACKAGE SPECIFIC SECTION
            Id = "wtime",
            Version = "1.0.0-alpha",
            PackageSourceUrl = new Uri("https://github.com/zverev-iv/choco-wtime/"),
            Owners = new[] {
                "zverev-iv"
                },
            //SOFTWARE SPECIFIC SECTION
            Title = "Wtime",
            Authors = new[] {
                "Tino Reichardt"
                },
            Copyright = "2021, Tino Reichardt",
            ProjectUrl = new Uri("https://github.com/mcmilk/wtime"),
            DocsUrl = new Uri("https://raw.githubusercontent.com/mcmilk/wtime/master/README.md"),
            BugTrackerUrl = new Uri("https://github.com/mcmilk/wtime/issues"),
            RequireLicenseAcceptance = false,
            Summary = "Windows Benchmark Tool",
            Description = @"The program will start COMMAND with the given OPTIONS and print out some statistic of it to stderr.

Sample output:

```cmd
ommand: 7z a silesia.7z -mmt=off -mx15 silesia

TIMES in milliseconds
RunningTime................. 32104
UserTime.................... 31793
KernelTime.................. 249

MEMORY in KiB
PageFaultCount.............. 112
PeakWorkingSetSize.......... 34856
WorkingSetSize.............. 20
QuotaPeakPagedPoolUsage..... 85
QuotaPagedPoolUsage......... 0
QuotaPeakNonPagedPoolUsage.. 6
QuotaNonPagedPoolUsage...... 0
PagefileUsage............... 0
PeakPagefileUsage........... 36296

IO count
ReadOperationCount.......... 81
WriteOperationCount......... 34
OtherOperationCount......... 115
ReadTransferCount........... 211939037
WriteTransferCount.......... 58043652
OtherTransferCount.......... 3414
```
            ",
            ReleaseNotes = new[] {
                "https://github.com/mcmilk/wtime/releases"
                },
            Files = new[] {
                new ChocolateyNuSpecContent {
                    Source = new DirectoryPath(BinDir).Combine("**").ToString(),
                    Target = "tools"
                    }
                },
            Tags = new[] {
                "Windows",
                "Benchmark",
                "cli",
                "RunningTime",
                "KernelTime",
                "time",
                "memory",
                "io"
                },

            //Cake internal settings
            //Debug = false,
            //Verbose = false,
            //Force = false,
            //Noop = false,
            //LimitOutput = false,
            //ExecutionTimeout = 13,
            //CacheLocation = @"C:\temp",
            //AllowUnofficial = false

        };
    }

    #endregion
}