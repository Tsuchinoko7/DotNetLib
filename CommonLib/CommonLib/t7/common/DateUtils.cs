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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public static double DiffDays(DateTime date1, DateTime date2)
        {
            double diff = (date1 - date2).TotalDays;

            return diff < 0 ? diff * -1 : diff;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public static double DiffHours(DateTime date1, DateTime date2)
        {
            double diff = (date1 - date2).TotalHours;

            return diff < 0 ? diff * -1 : diff;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public static double DiffMinutes(DateTime date1, DateTime date2)
        {
            double diff = (date1 - date2).TotalMinutes;

            return diff < 0 ? diff * -1 : diff;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public static double DiffSeconds(DateTime date1, DateTime date2)
        {
            double diff = (date1 - date2).TotalSeconds;

            return diff < 0 ? diff * -1 : diff;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public static double DiffMilliseconds(DateTime date1, DateTime date2)
        {
            double diff = (date1 - date2).TotalMilliseconds;

            return diff < 0 ? diff * -1 : diff;
        }
    }
}
