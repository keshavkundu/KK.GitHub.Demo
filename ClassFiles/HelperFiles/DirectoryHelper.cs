/* 
 Created By:        Keshav Kundu
 Created Date:      03-10-2021
 Modified Date:     NA
 Purpose:           This class is used to open the Folder where the CSV is downloaded.
 Purpose Type:      This static class is reusable for opening any directory location.
 Referenced files:  GithubDemo.cs file.
 */
using System.Diagnostics;
using System.IO;
namespace KK.GitHub.Demo.ClassFiles.HelperFiles
{
    public class DirectoryHelper
    {
        public static bool OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
