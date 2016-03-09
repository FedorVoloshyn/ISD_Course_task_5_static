using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_5_static
{
    static class StringExtension
    {
        public static string Substring_My(this string currentString, int indexOfFirstSym, int indexOfLastSym)
        {
            if(indexOfFirstSym < indexOfLastSym)
            {
                string resultString = "";
                for (int i = indexOfFirstSym; i < indexOfLastSym; i++)
                    resultString += currentString[i];
                return resultString;
            }
            else
               return "";
        }
        public static int IndexOf_My(this string currentString, string str)
        {
            for (int i = 0; i < currentString.Length - str.Length; i++)
            {
                string buffer = "";
                for (int j = i; j < i + str.Length; j++)
                {
                    buffer += currentString[j];
                }
                if (buffer == str)
                    return i;
            }
            return -1;
        }
        // нужно рефакторить, ужасная логика, спасибо, что хоть работает
        public static string Replace_My(this string currentString, string oldValue, string newValue) 
        {
            string resultString = "";
            for (int i = 0; i < currentString.Length; i++)
            {
                if (i < currentString.Length - oldValue.Length)
                {
                    string buffer = "";
                    for (int j = i; j < i + oldValue.Length; j++)
                    {
                        buffer += currentString[j];
                    }
                    if (buffer == oldValue)
                    {
                        resultString += newValue;
                        i += oldValue.Length - 1;
                    }
                    else
                        resultString += currentString[i];
                }
                else
                    resultString += currentString[i];
            }
            return resultString;
        }
    }
}
