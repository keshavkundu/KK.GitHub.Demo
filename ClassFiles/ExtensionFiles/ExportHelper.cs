/* 
 Created By:        Keshav Kundu
 Created Date:      03-10-2021
 Modified Date:     NA
 Purpose:           This class is used for exporting a datatable into csv format and logging exception.
 Purpose Type:      This extention method is reusable for exporting a csv from any datatable format and logging in text file.
 Referenced files:  GithubDemo.cs file.
 */
using KK.GitHub.Demo.ClassFiles.Constants;
using System;
using System.Data;
using System.IO;
using System.Linq;
namespace KK.GitHub.Demo.ClassFiles.ExtensionFiles
{
    public static class ExportHelper
    {
        public static void ExportToCSV(this DataTable dtDataTable, string strFilePath)
        {
            try
            {
                string strFileName = string.Format("{0}{1}{2}{3}", strFilePath, ApplicationConstants.exportCsvFileName.Replace(".csv", ""),
                   DateTime.Now.ToString("dd'_'MMM'_'yyyy'_'HH'_'mm'_'ss"), ".csv");
                using (StreamWriter streamWriter = new StreamWriter(strFileName, false))
                {
                    //Start of row writing process
                    foreach (DataColumn column in dtDataTable.Columns)
                    {
                        streamWriter.Write(column.ColumnName);
                        streamWriter.Write(",");
                    }
                    streamWriter.Write(streamWriter.NewLine);
                    //End of column writing process

                    //Start of row writing process
                    foreach (DataRow row in dtDataTable.Rows)
                    {
                        foreach (DataColumn column in dtDataTable.Columns)
                        {
                            string value = Convert.ToString(row[column]);
                            if (value.Contains(',')) //To handle comma
                            {
                                value = string.Format("\"{0}\"", value);
                                streamWriter.Write(value);
                            }
                            else if (value.Contains("\"")) //To handle double quotes
                            {
                                value = string.Format("\"{0}\"", value.Replace("\"", "\"\""));
                                streamWriter.Write(value);
                            }
                            else
                            {
                                streamWriter.Write(value);
                            }
                            streamWriter.Write(",");
                        }
                        streamWriter.Write(streamWriter.NewLine);
                    }
                    //End of row writing process
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Log an exception using helper method
        /// </summary>
        /// <param name="exception">Exception object</param>
        /// <param name="strFilePath">Folder path to log exception</param>
        public static bool LogException(this Exception exception, string strFilePath)
        {
            try
            {
                string strFileName = string.Format("{0}{1}{2}{3}", strFilePath, ApplicationConstants.exceptionFileName.Replace(".txt", ""),
                    DateTime.Now.ToString("dd'_'MMM'_'yyyy'_'HH'_'mm'_'ss"), ".txt");
                using (StreamWriter streamWriter = new StreamWriter(strFileName, false))
                {
                    streamWriter.Write("Exception Message: " + exception.Message);
                    streamWriter.Write(streamWriter.NewLine);
                    streamWriter.Write("Exception InnerException: " + exception.InnerException);
                    streamWriter.Write(streamWriter.NewLine);
                    streamWriter.Write("Exception StackTrace: " + exception.StackTrace);
                    streamWriter.Write(streamWriter.NewLine);
                    streamWriter.Close();
                }
                return true;
            }
            catch (Exception)
            {
                
                //In case exception occurs while logging the exception show message to user.
            }
            return false;
        }
    }
}
