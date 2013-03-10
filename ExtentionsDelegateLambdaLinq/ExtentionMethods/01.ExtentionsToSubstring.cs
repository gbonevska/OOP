using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    static class ExtentionsToSubstring
    {
        /* 01. Implement an extension method Substring(int index, int length) for the class StringBuilder 
         * that returns new StringBuilder and has the same functionality as Substring in the class String.
        */
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            string strValue = str.ToString();
            strValue = strValue.Substring(index, length);
            StringBuilder result = new StringBuilder();
            return result.Append(strValue);
        }
    }
}
