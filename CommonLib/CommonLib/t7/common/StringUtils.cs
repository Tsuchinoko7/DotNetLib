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
            if (val == null)
            {
                return true;
            }

            int len = val.Length;

            for (int i = 0; i < len; i++)
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
