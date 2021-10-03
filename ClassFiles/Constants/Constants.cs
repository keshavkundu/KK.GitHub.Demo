/* 
 Created By:        Keshav Kundu
 Created Date:      03-10-2021
 Modified Date:     NA
 Purpose:           A constant class to store all the harcoded values in application.
 Future Scope:      Some of the constants can be included in App.config file.
 Referenced files:  GithubDemo.cs file.
 */
namespace KK.GitHub.Demo.ClassFiles.Constants
{
    public static class ApplicationConstants
    {
        public const string gitHubUrl = "https://api.github.com";
        public const string firstColumn = "Commented Words";
        public const string secondColumn = "Occurence";
        public const string fileExplorer = "explorer.exe";
        public const string exceptionFileName = "/LogsGitHubBI.txt";
        public const string exportCsvFileName = "/ExportGitHubComments.csv";
    }
}
