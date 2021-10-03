/* 
 Created By:        Keshav Kundu
 Created Date:      02-10-2021
 Modified Date:     NA
 Purpose:           Figure out which string is in ascending order based on ASCII characters 
                    present in the string.
 Referenced files:  Used by BinarySearchTree class file.
 */
namespace KK.GitHub.Demo.ClassFiles.LogicFiles
{
    public class Sorting
    {
        /// <summary>
        /// Compare two strings
        /// </summary>
        /// <param name="leftString"></param>
        /// <param name="rightString"></param>
        /// <returns>0 for equal, positive if left string in less, negative if right string is less</returns>
        public static int AsciiSortStrings(string leftString, string rightString)
        {
            int returnVal = 0; //Consider them equal
            char[] leftChar = leftString.ToCharArray();
            char[] rightChar = rightString.ToCharArray();
            int totalCharToCompare = (leftChar.Length > rightChar.Length) ? rightChar.Length : leftChar.Length;
            for (int i = 0; i < totalCharToCompare; i++)
            {
                returnVal = rightChar[i].CompareTo(leftChar[i]); //Positive if left char is less
                if (returnVal > 0 || returnVal < 0)
                    break;
            }
            if (returnVal == 0 && (leftChar.Length > rightChar.Length))
                return -1;
            else if (returnVal == 0 && (leftChar.Length < rightChar.Length))
                return 1;
            return returnVal;
        }
    }
}
