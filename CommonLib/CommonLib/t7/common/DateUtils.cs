namespace t7.common
{
    using System;
    using System.Globalization;

    /// <summary>
    /// 
    /// </summary>
    public class DateUtils
    {
        private static string[] dateFormats =
        {
            "yyyy/MM/dd",
            "yyyy/MM/dd HH:mm:ss",
            "yyyy-MM-dd",
            "yyyy-MM-dd HH:mm:ss"
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime ToDate(string str)
        {
            return DateTime.ParseExact(str.Trim(), dateFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsDate(string str)
        {
            DateTime resuult;
            bool isDate =
                DateTime.TryParseExact(str.Trim(), dateFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out resuult);

            return isDate;
        }
    }
}
