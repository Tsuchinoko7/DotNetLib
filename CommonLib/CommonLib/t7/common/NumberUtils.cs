namespace t7.common
{
    /// <summary>
    /// 
    /// </summary>
    public class NumberUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int ToInt(string val)
        {
            int result = 0;
            bool isInt = int.TryParse(val, out result);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static bool IsInt(string val)
        {
            int result = 0;
            return int.TryParse(val, out result);
        }
    }
}
