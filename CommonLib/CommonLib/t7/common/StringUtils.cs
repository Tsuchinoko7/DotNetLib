namespace t7.common
{
    /// <summary>
    /// String Utils
    /// </summary>
    public class StringUtils
    {
        /// <summary>
        /// A String for a space character.
        /// </summary>
        public const string SPACE = " ";

        /// <summary>
        /// The empty String <code>""</code>.
        /// </summary>
        public const string EMPTY = "";

        /// <summary>
        /// A String for linefeed LF ("\n").
        /// </summary>
        public const string LF = "\n";

        /// <summary>
        /// A String for carriage return CR ("\r").
        /// </summary>
        public const string CR = "\r";

        /// <summary>
        /// Represents a failed index search.
        /// </summary>
        private const int INDEX_NOT_FOUND = -1;

        /// <summary>
        /// 
        /// </summary>
        public StringUtils() : base()
        {
        }

        /// <summary>
        /// <para>Checks if a String is empty ("") or null.</para>
        /// </summary>
        /// <param name="str">the String to check, may be null</param>
        /// <returns>true if the String is empty or null</returns>
        public static bool IsEmpty(string str)
        {
            return str == null || str.Length == 0;
        }

        /// <summary>
        /// <para>Checks if a String is not empty ("") and not null.</para>
        /// </summary>
        /// <param name="str">the String to check, may be null</param>
        /// <returns>true if the String is not empty and not null</returns>
        public static bool IsNotEmpty(string str)
        {
            return !IsEmpty(str);
        }

        /// <summary>
        /// <para>Checks if any one of the Strings are empty ("") or null.</para>
        /// </summary>
        /// <param name="strs">the Strings to check, may be null or empty</param>
        /// <returns>true if any of the Strings are empty or null</returns>
        public static bool IsAnyEmpty(params string[] strs)
        {
            if (strs == null)
            {
                return true;
            }

            foreach (var val in strs)
            {
                if (IsEmpty(val))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// <para>Checks if none of the Strings are empty ("") or null.</para>
        /// </summary>
        /// <param name="strs">the Strings to check, may be null or empty</param>
        /// <returns>true if none of the Strings are empty or null</returns>
        public static bool IsNoneEmpty(params string[] strs)
        {
            return !IsAnyEmpty(strs);
        }

        /// <summary>
        /// <para>Checks if a String is whitespace, empty ("") or null.</para>
        /// </summary>
        /// <param name="str">the String to check, may be null</param>
        /// <returns>true if the String is null, empty or whitespace</returns>
        public static bool IsBlank(string str)
        {
            if (str == null || str.Length == 0)
            {
                return true;
            }

            int len = str.Length;

            for (int i = (len - 1); i >= 0; i--)
            {
                if (!char.IsWhiteSpace(str[i]))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// <para>Checks if a String is not empty (""), not null and not whitespace only.</para>
        /// </summary>
        /// <param name="str">the String to check, may be null</param>
        /// <returns>true if the String is not empty and not null and not whitespace</returns>
        public static bool IsNotBlank(string str)
        {
            return !IsBlank(str);
        }

        /// <summary>
        /// <para>Checks if any one of the Strings are blank ("") or null and not whitespace only.</para>
        /// </summary>
        /// <param name="strs">the Strings to check, may be null or empty</param>
        /// <returns>true if any of the Strings are blank or null or whitespace only</returns>
        public static bool IsAnyBlank(params string[] strs)
        {
            if (strs == null)
            {
                return true;
            }

            foreach (var val in strs)
            {
                if (IsBlank(val))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// <para>Checks if none of the Strings are blank ("") or null and whitespace only.</para>
        /// </summary>
        /// <param name="strs">the Strings to check, may be null or empty</param>
        /// <returns>true if none of the Strings are blank or null or whitespace only</returns>
        public static bool IsNoneBlank(params string[] strs)
        {
            return !IsAnyBlank(strs);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Trim(string str)
        {
            return str == null ? null : str.Trim();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string TrimToNull(string str)
        {
            string result = Trim(str);

            return IsEmpty(result) ? null : result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string TrimToEmpty(string str)
        {
            return str == null ? string.Empty : Trim(str);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Strip(string str)
        {
            return Trim(str);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string StripToNull(string str)
        {
            return TrimToNull(str);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string StripToEmpty(string str)
        {
            return TrimToEmpty(str);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="stripChars"></param>
        /// <returns></returns>
        public static string Strip(string str, string stripChars)
        {
            string strip = StripStart(str, stripChars);
            return StripEnd(strip, stripChars);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="stripChars"></param>
        /// <returns></returns>
        public static string StripStart(string str, string stripChars)
        {
            if (str == null || str.Length == 0)
            {
                return str;
            }

            int len = str.Length;
            int start = 0;

            if (stripChars == null)
            {
                while (len > start && char.IsWhiteSpace(str[start]))
                {
                    start++;
                }
            }
            else
            {
                while (len > start && stripChars.IndexOf(str[start]) != INDEX_NOT_FOUND)
                {
                    start++;
                }
            }

            return str.Substring(start);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="stripChars"></param>
        /// <returns></returns>
        public static string StripEnd(string str, string stripChars)
        {
            if (str == null || str.Length == 0)
            {
                return str;
            }

            int end = str.Length;

            if (stripChars == null)
            {
                while (end > 0 && char.IsWhiteSpace(str[end - 1]))
                {
                    end--;
                }
            }
            else
            {
                while (end > 0 && stripChars.IndexOf(str[end - 1]) != INDEX_NOT_FOUND)
                {
                    end--;
                }
            }

            return str.Substring(0, end);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static string[] StripAll(string[] strs)
        {
            return StripAll(strs, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strs"></param>
        /// <param name="stripChars"></param>
        /// <returns></returns>
        public static string[] StripAll(string[] strs, string stripChars)
        {
            if (strs == null || strs.Length == 0)
            {
                return strs;
            }

            int valsLen = strs.Length;
            string[] array = new string[strs.Length];

            for (int i = 0; i < valsLen; i++)
            {
                array[i] = Strip(strs[i], stripChars);
            }

            return array;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool Equals(string str1, string str2)
        {
            if (str1 == null)
            {
                return str2 == null;
            }

            return str1.Equals(str2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool EqualsIgnoreCase(string str1, string str2)
        {
            if (str1 == null || str2 == null)
            {
                return str1 == str2;
            }

            return str1.ToLower().Equals(str2.ToLower());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="searchChar"></param>
        /// <returns></returns>
        public static int IndexOf(string str, char searchChar)
        {
            if (IsEmpty(str))
            {
                return INDEX_NOT_FOUND;
            }

            return str.IndexOf(searchChar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="searchChar"></param>
        /// <param name="startPos"></param>
        /// <returns></returns>
        public static int IndexOf(string str, char searchChar, int startPos)
        {
            if (IsEmpty(str))
            {
                return INDEX_NOT_FOUND;
            }

            if (str.Length < startPos)
            {
                return INDEX_NOT_FOUND;
            }

            return str.IndexOf(searchChar, startPos < 0 ? 0 : startPos);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public static int IndexOf(string str, string searchString)
        {
            if (str == null || searchString == null)
            {
                return INDEX_NOT_FOUND;
            }

            if (IsEmpty(searchString))
            {
                return 0;
            }

            return str.IndexOf(searchString);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="searchString"></param>
        /// <param name="startPos"></param>
        /// <returns></returns>
        public static int IndexOf(string str, string searchString, int startPos)
        {
            if (str == null || searchString == null)
            {
                return INDEX_NOT_FOUND;
            }

            int len = str.Length;

            if (IsEmpty(searchString))
            {
                return len < startPos ? len : startPos;
            }

            if (len < startPos)
            {
                return INDEX_NOT_FOUND;
            }

            return str.IndexOf(searchString, startPos < 0 ? 0 : startPos);
        }
    }
}
