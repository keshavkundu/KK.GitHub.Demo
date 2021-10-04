﻿using KK.GitHub.Demo.ClassFiles.Constants;
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
        public static DataTable sortAndBindListToDataTable(this List<Word> wordList)
        {
            string tempVariable = string.Empty;

            //Intialise the DataTable with the columns
            DataTable dtResultTable = new DataTable();
            dtResultTable.Columns.Add(ApplicationConstants.firstColumn, typeof(string));
            dtResultTable.Columns.Add(ApplicationConstants.secondColumn, typeof(int));


            string[] wordsToBeSorted = wordList.Select(x => x.CommentedWord).ToArray();
            int length = wordsToBeSorted.Length;
            
            //Bubble sort process starting
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (getASCIIValue(wordsToBeSorted[j]) > getASCIIValue(wordsToBeSorted[j + 1]))
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

        #region private methods
        private static int getASCIIValue(string input)
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
