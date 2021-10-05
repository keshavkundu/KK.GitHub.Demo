using KK.GitHub.Demo.ClassFiles.Constants;
using KK.GitHub.Demo.ClassFiles.Model;
using System;
/* 
 Created By:        Keshav Kundu
 Created Date:      04-10-2021
 Modified Date:     NA
 Purpose:           This class is used for exporting a list of word into datatable after bubble sorting.
 Referenced files:  GithubDemo.cs file.
 */
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace KK.GitHub.Demo.ClassFiles.ExtensionFiles
{
    public static class BubbleSort
    {
        /// <summary>
        /// Extension method for converting list of type wordlist to DataTable
        /// </summary>
        /// <param name="wordList"></param>
        /// <returns>Datatable</returns>
        public static DataTable SortAndBindListToDataTable(this List<Word> wordList)
        {

            try
            {
                //Intialise the DataTable
                DataTable dtResultTable = new DataTable();
                //Add default columns to DataTable
                dtResultTable.Columns.Add(ApplicationConstants.firstColumn, typeof(string));
                dtResultTable.Columns.Add(ApplicationConstants.secondColumn, typeof(int));

                string tempVariable = string.Empty;
                string[] wordsToBeSorted = wordList.Select(x => x.CommentedWord).ToArray();
                int length = wordsToBeSorted.Length;

                //Bubble sort process starting
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length - 1; j++)
                    {
                        if (GetASCIIValue(wordsToBeSorted[j]) > GetASCIIValue(wordsToBeSorted[j + 1]))
                        {
                            tempVariable = wordsToBeSorted[j];
                            wordsToBeSorted[j] = wordsToBeSorted[j + 1];
                            wordsToBeSorted[j + 1] = tempVariable;
                        }
                    }
                }

                //Converting the sorted words to Datatable
                for (int i = 0; i < wordsToBeSorted.Length; i++)
                {
                    DataRow drRow = dtResultTable.NewRow();
                    int countOfWord = wordList.Where(x => x.CommentedWord.Equals(wordsToBeSorted[i])).FirstOrDefault().Occurence;
                    drRow[0] = wordsToBeSorted[i];
                    drRow[1] = countOfWord;
                    dtResultTable.Rows.Add(drRow);
                }
                //return the datatable
                return dtResultTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #region private methods
        private static int GetASCIIValue(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }
        #endregion
    }
}
