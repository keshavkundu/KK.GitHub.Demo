using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KK.GitHub.Demo.ClassFiles.LogicFiles
{
    class Sorting
    {
        public static int AsciSortStrings(string leftString, string rightString)
        {
            char[] leftChar = leftString.ToCharArray();
            char[] rightChar = rightString.ToCharArray();
            int comparisonValue = 0;
            //0 for equal, 1 if left string in less, -1 if right string is less
            int totalCharToCompare; //to compare the maximum characters common for both the strings
            if (leftChar.Length > rightChar.Length)
            {
                totalCharToCompare = rightChar.Length;
            }
            else
            {
                totalCharToCompare = leftChar.Length;
            }
            for (int i = 0; i < totalCharToCompare; i++)
            {
                if (leftChar[i] < rightChar[i])
                {
                    comparisonValue = 1;
                    break;
                }
                else if (leftChar[i] > rightChar[i])
                {
                    comparisonValue = -1;
                    break;
                }
                else
                    comparisonValue = 0;
            }
            return comparisonValue;
        }
    }
}
