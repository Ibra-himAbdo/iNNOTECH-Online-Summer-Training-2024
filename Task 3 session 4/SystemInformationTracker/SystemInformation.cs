using ConsoleTables;
using System.Management;

namespace SystemInformationTracker;

internal static class SystemInformation
{
    static string RamInfo { get; set; } = string.Empty;
    static string CpuInfo { get; set; } = string.Empty;
    static ConsoleTable RunningProcesses { get; set; } = new ConsoleTable("Process Name", "Process ID", "Thread Count", "Working Set Size");

    public static void GetSystemInformation()
    {
        GetRamInfo();
        GetCpuInfo();
        GetRunningProcesses();
        SaveToFile();
    }

    private static void ExecuteWMIQuery(string query, Action<ManagementObject> processResult)
    {
        try
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject obj in searcher.Get())
            {
                processResult(obj);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while executing WMI query '{query}': {e.Message}");
        }
    }

    private static void GetRamInfo()
    {
        ExecuteWMIQuery("SELECT * FROM Win32_OperatingSystem", obj =>
        {
            double totalMemoryKB = Convert.ToDouble(obj["TotalVisibleMemorySize"]);
            double totalMemoryMB = totalMemoryKB / 1024.0;

            double freeMemoryKB = Convert.ToDouble(obj["FreePhysicalMemory"]);
            double freeMemoryMB = freeMemoryKB / 1024.0;

            RamInfo = $"Total Physical Memory: {totalMemoryMB} MB\n" +
            $"Available Physical Memory: {freeMemoryMB} MB";

            Console.WriteLine(RamInfo);
        });
    }

    private static void GetCpuInfo()
    {
        ExecuteWMIQuery("SELECT * FROM Win32_Processor", obj =>
        {
            string cpuName = obj["Name"]?.ToString();
            int cores = Convert.ToInt32(obj["NumberOfCores"]);
            int threads = Convert.ToInt32(obj["NumberOfLogicalProcessors"]);

            CpuInfo = $"CPU Name: {cpuName}\n" +
            $"Number of Cores: {cores}\n" +
            $"Number of Threads: {threads}";

            Console.WriteLine(CpuInfo);
        });
    }

    private static void GetRunningProcesses()
    {
        ExecuteWMIQuery("SELECT * FROM Win32_Process", obj =>
        {
            string processName = obj["Name"]?.ToString();
            string processId = obj["ProcessId"]?.ToString();
            string executablePath = obj["ExecutablePath"]?.ToString();
            string commandLine = obj["CommandLine"]?.ToString();
            string threadCount = obj["ThreadCount"]?.ToString();
            string workingSetSize = obj["WorkingSetSize"]?.ToString();

            RunningProcesses.AddRow(processName, processId, threadCount, workingSetSize);
        });

        RunningProcesses.Write(Format.Minimal);
    }

    private static void SaveToFile()
    {
        var folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tracked System Informations");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
        var fileCount = Directory.GetFiles(folderPath).Length;

        var filePath = Path.Combine(folderPath, $"SystemInformationTracker_{fileCount + 1}.txt");

        var content = $"{CpuInfo}\n\n" +
                      $"{RamInfo}\n\n" +
                      $"{RunningProcesses}\n\n";

        File.WriteAllText(filePath, content);

        Console.WriteLine($"File saved to {filePath}\n\n");
    }

}