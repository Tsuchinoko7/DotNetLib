namespace t7.common
{
    public class NumberUtils
    {
        public static int ToInt(string val)
        {
            int result = 0;
            bool isInt = int.TryParse(val, out result);

            return result;
        }

        public static bool IsInt(string val)
        {
            int result = 0;
            return int.TryParse(val, out result);
        }
    }
}
