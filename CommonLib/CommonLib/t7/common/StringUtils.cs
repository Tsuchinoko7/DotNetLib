namespace t7.common
{
    public class StringUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool IsEmpty(string val)
        {
            return val == null || val.Length == 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool IsNotEmpty(string val)
        {
            return !IsEmpty(val);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vals"></param>
        /// <returns></returns>
        public static bool IsAnyEmpty(params string[] vals)
        {
            if (vals == null)
            {
                return true;
            }

            foreach (var val in vals)
            {
                if (IsEmpty(val))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vals"></param>
        /// <returns></returns>
        public static bool IsNoneEmpty(params string[] vals)
        {
            return !IsAnyEmpty(vals);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool IsBlank(string val)
        {
            if (val == null || val.Length == 0)
            {
                return true;
            }

            int len = val.Length;

            for (int i = (len - 1); i >= 0; i--)
            {
                if (!char.IsWhiteSpace(val[i]))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool IsNotBlank(string val)
        {
            return !IsBlank(val);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vals"></param>
        /// <returns></returns>
        public static bool IsAnyBlank(params string[] vals)
        {
            if (vals == null)
            {
                return true;
            }

            foreach (var val in vals)
            {
                if (IsBlank(val))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vals"></param>
        /// <returns></returns>
        public static bool IsNoneBlank(params string[] vals)
        {
            return !IsAnyBlank(vals);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string Trim(string val)
        {
            return val == null ? null : val.Trim();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string TrimToNull(string val)
        {
            string result = Trim(val);

            return IsEmpty(result) ? null : result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string TrimToEmpty(string val)
        {
            return val == null ? string.Empty : Trim(val);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string Strip(string val)
        {
            return Trim(val);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string StripToNull(string val)
        {
            return TrimToNull(val);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string StripToEmpty(string val)
        {
            return TrimToEmpty(val);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <param name="stripChars"></param>
        /// <returns></returns>
        public static string Strip(string val, string stripChars)
        {
            string strip = StripStart(val, stripChars);
            return StripEnd(strip, stripChars);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <param name="stripChars"></param>
        /// <returns></returns>
        public static string StripStart(string val, string stripChars)
        {
            if (val == null || val.Length == 0)
            {
                return val;
            }

            int len = val.Length;
            int start = 0;

            if (stripChars == null)
            {
                while (len > start && char.IsWhiteSpace(val[start]))
                {
                    start++;
                }
            }
            else
            {
                while (len > start && stripChars.IndexOf(val[start]) != -1)
                {
                    start++;
                }
            }

            return val.Substring(start);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <param name="stripChars"></param>
        /// <returns></returns>
        public static string StripEnd(string val, string stripChars)
        {
            if (val == null || val.Length == 0)
            {
                return val;
            }

            int end = val.Length;

            if (stripChars == null)
            {
                while (end > 0 && char.IsWhiteSpace(val[end - 1]))
                {
                    end--;
                }
            }
            else
            {
                while (end > 0 && stripChars.IndexOf(val[end - 1]) != -1)
                {
                    end--;
                }
            }

            return val.Substring(0, end);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vals"></param>
        /// <returns></returns>
        public static string[] StripAll(string[] vals)
        {
            return StripAll(vals, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vals"></param>
        /// <param name="stripChars"></param>
        /// <returns></returns>
        public static string[] StripAll(string[] vals, string stripChars)
        {
            if (vals == null || vals.Length == 0)
            {
                return vals;
            }

            int valsLen = vals.Length;
            string[] array = new string[vals.Length];

            for (int i = 0; i < valsLen; i++)
            {
                array[i] = Strip(vals[i], stripChars);
            }

            return array;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static bool Equals(string val1, string val2)
        {
            if (val1 == null)
            {
                return val2 == null;
            }

            return val1.Equals(val2);
        }
    }
}
