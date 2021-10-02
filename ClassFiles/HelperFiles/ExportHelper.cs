/* 
 Created By:        Keshav Kundu
 Created Date:      03-10-2021
 Modified Date:     NA
 Purpose:           This class is used for exporting a datatable into csv format.
 Purpose Type:      This extention method is reusable for exporting a csv from any datatable format.
 Referenced files:  GithubDemo.cs file.
 */
using System;
using System.Data;
using System.IO;
using System.Linq;
namespace KK.GitHub.Demo.ClassFiles.HelperFiles
{
    public static class ExportHelper
    {
        public static void ExportToCSV(this DataTable dtDataTable, string strFilePath)
        {
            using (StreamWriter streamWriter = new StreamWriter(strFilePath, false))
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
                foreach(DataRow row in dtDataTable.Rows)
                {
                    foreach(DataColumn column in dtDataTable.Columns)
                    {
                        string value = Convert.ToString(row[column]);
                        if (value.Contains(','))
                        {
                            value = string.Format("\"{0}\"", value);
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
    }
}
