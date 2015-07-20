namespace CommonLib
{
    public class StringUtils
    {
        public static bool IsEmpty(string val)
        {
            if (val == null)
            {
                return true;
            }

            return val.Equals(string.Empty);
        }

        public static bool IsNotEmpty(string val)
        {
            return !IsEmpty(val);
        }

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

        public static bool IsNoneEmpty(params string[] vals)
        {
            return !IsAnyEmpty(vals);
        }

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
