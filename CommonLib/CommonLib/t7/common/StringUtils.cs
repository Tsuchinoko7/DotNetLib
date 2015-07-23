namespace CommonLib
{
    public class StringUtils
    {
        private static char[] whitespaceChars = new char[] { ' ', '　', '\f', '\n', '\r', '\t', '\v' };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool IsEmpty(string val)
        {
            if (val == null)
            {
                return true;
            }

            return val.Equals(string.Empty);
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
            if (val == null)
            {
                return true;
            }

            foreach (var c in val)
            {
                bool isWhitespaceChar = false;

                foreach (var whitespaceChar in whitespaceChars)
                {
                    if (c.Equals(whitespaceChar))
                    {
                        isWhitespaceChar = true;
                        break;
                    }
                }

                if (!isWhitespaceChar)
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
            if (val == null)
            {
                return null;
            }

            return val.Trim();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string TrimToNull(string val)
        {
            if (val == null)
            {
                return null;
            }

            string result = val.Trim();

            return result.Length > 0 ? result : null;
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
