using System;
using Com.GwennDiaz.Utils.Replace;

namespace Com.GwennDiaz.Utils.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Get String Inside Tag
        /// </summary>
        /// <param name="str"></param>
        /// <param name="beginTag"></param>
        /// <param name="endTag"></param>
        /// <returns></returns>
        public static string GetInsideTag(this String str, string beginTag, string endTag)
        {
            int pFrom = str.IndexOf(beginTag, StringComparison.Ordinal) + beginTag.Length;
            int pTo = str.LastIndexOf(endTag, StringComparison.Ordinal);
            if (pTo - pFrom < 0)
            {
                return "";
            }

            string result = str.Substring(pFrom, pTo - pFrom);
            return result;
        }
        
        /// <summary>
        /// Get String After Tag
        /// </summary>
        /// <param name="str"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public static string GetAfterTag(this String str, string tag)
        {
            return str.Substring(str.LastIndexOf(tag, StringComparison.Ordinal) + tag.Length);
        }

        /// <summary>
        /// Replace All Char of a string with a protocol
        /// </summary>
        /// <param name="str"></param>
        /// <param name="replaceProtocol"></param>
        /// <returns></returns>
        public static string Replace(this string str, StringReplace replaceProtocol)
        {
            foreach (var replace in replaceProtocol.charReplaces)
            {
                str = str.Replace(replace.oldChar, replace.newChar);
            }
            
            return str;
        }
    }
}

