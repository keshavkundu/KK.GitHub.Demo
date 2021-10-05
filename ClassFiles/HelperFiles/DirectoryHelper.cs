/* 
 Created By:        Keshav Kundu
 Created Date:      03-10-2021
 Modified Date:     NA
 Purpose:           This class is used to open the Folder where the CSV is downloaded and 
                    uses singleton design pattern.
 Purpose Type:      This static class is reusable for opening any directory location.
 Referenced files:  GithubDemo.cs file.
 */
using System;
using System.Diagnostics;
using System.IO;
namespace KK.GitHub.Demo.ClassFiles.HelperFiles
{
    public class DirectoryHelper
    {
        private static DirectoryHelper instance;
        private DirectoryHelper()
        {
        }
        public static DirectoryHelper GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DirectoryHelper();
                }
                return instance;
            }
        }

        /// <summary>
        /// Open Folder path
        /// </summary>
        /// <param name="folderPath">The location of the folder</param>
        /// <returns>true if found else false</returns>
        public bool OpenFolder(string folderPath)
        {
            try
            {
                if (Directory.Exists(folderPath))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo()
                    {
                        Arguments = folderPath,
                        FileName = Constants.ApplicationConstants.fileExplorer
                    };
                    Process.Start(startInfo);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
