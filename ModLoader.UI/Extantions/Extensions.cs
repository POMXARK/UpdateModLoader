
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Path = System.IO.Path;

public static class Extensions
{
    public static async Task DownloadFile(this HttpClient client, string address, string fileName)
    {
        using (var response = await client.GetAsync(address))
        using (var stream = await response.Content.ReadAsStreamAsync())
        using (var file = File.OpenWrite(fileName))
        {
            stream.CopyTo(file);
        }
    }

    public static void RunDownload(string linkDownload, string resouseName, string modName, uint waitTime)
    {
        Process cmd = new Process();
        cmd.StartInfo.FileName = "download";
        cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        const string quote = "\"";
        var path = quote + $"C:\\Users\\User\\Downloads\\TEST\\downloads_new\\{resouseName}\\" + RemoveInvalidChars(modName) + quote;
        cmd.StartInfo.Arguments = $"https://modsfire.com/d/{linkDownload} {path} {waitTime}";
        cmd.StartInfo.CreateNoWindow = true;
        cmd.Start();
    }

    /// <summary>
    /// Возвращает валидное название для создаваемой папки
    /// </summary>
    /// <param name="filename"></param>
    /// <returns></returns>
    public static string RemoveInvalidChars(string filename)
    {
        return string.Concat(filename.Split(Path.GetInvalidFileNameChars()));
    }

    public static string[] GetAllFiles(string path, string searchPattern)
    {
        var test = Directory.GetFiles(path, searchPattern, SearchOption.AllDirectories);
        return test;
    }

    public static void Unpack(string[] allFiles)
    {
        foreach (var pathFile in allFiles)
        {
            var typeFile = Path.GetExtension(pathFile);

            switch (typeFile)
            {
                case ".rar":
                case ".7z":
                case ".zip":
                    ExtractFile(pathFile, "C:\\Users\\User\\Downloads\\TEST\\unpack");
                    break;
                case ".package":
                case ".ts4script":
                    var fileName = Path.GetFileName(pathFile);
                    // Use the Path.Combine method to safely append the file name to the path.
                    // Will overwrite if the destination file already exists.
                    File.Copy(pathFile, Path.Combine("C:\\Users\\User\\Downloads\\TEST\\unpack", fileName), true);
                    break;
            }

        }
        
    }

    public static void ExtractFile(string sourceArchive, string destination)
    {
        string zPath = "7za.exe"; //add to proj and set CopyToOuputDir
        try
        {
            ProcessStartInfo proс = new ProcessStartInfo();
            proс.WindowStyle = ProcessWindowStyle.Hidden;
            proс.FileName = zPath;
            proс.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", sourceArchive, destination);
            proс.CreateNoWindow = true;
            Process x = Process.Start(proс);
            x.WaitForExit();
        }
        catch (System.Exception Ex)
        {
            //handle error
        }
    }

    public static void CreateZip(string sourceName, string targetArchive)
    {
        ProcessStartInfo proc = new ProcessStartInfo();
        proc.FileName = "7za.exe";
        proc.Arguments = string.Format("a -tgzip \"{0}\" \"{1}\" -mx=9", targetArchive, sourceName);
        proc.CreateNoWindow = true;
        proc.WindowStyle = ProcessWindowStyle.Hidden;
        Process x = Process.Start(proc);
        x.WaitForExit();
    }

    public static void CreateSymbolicLinkForPack(string pathFile)
    {
        Directory.CreateSymbolicLink("C:\\Users\\User\\Documents\\Electronic Arts\\The Sims 4\\saves\\" + Path.GetFileName(pathFile), pathFile);
    }

}