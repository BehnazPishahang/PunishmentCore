using System;
using System.Globalization;

namespace Utility.CalendarHelper
{
    public static class CalendarHelper
    {
        /// <summary>
        ///  get dateTime Now with shamsi
        /// </summary>
        /// <returns></returns>
        public static DateTime DateTimeNow()
        {
            return DateTime.Now.ToPersianDate();
        }

        public static string ToPersian(this DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(dateTime);
            int month = pc.GetMonth(dateTime);
            int day = pc.GetDayOfMonth(dateTime);
            int hour = pc.GetHour(dateTime);
            int min = pc.GetMinute(dateTime);

            DateTime PersianDateTime = new DateTime(year, month, day, hour, min, 0);

            return PersianDateTime.ToString("yyyy/MM/dd HH:mm");
        }

        public static DateTime ToPersianDateTime(this DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(dateTime);
            int month = pc.GetMonth(dateTime);
            int day = pc.GetDayOfMonth(dateTime);
            int hour = pc.GetHour(dateTime);
            int min = pc.GetMinute(dateTime);

            return new DateTime(year, month, day, hour, min, 0);
        }

        public static DateTime ToPersianDate(this DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(dateTime);
            int month = pc.GetMonth(dateTime);
            int day = pc.GetDayOfMonth(dateTime);

            return new DateTime(year, month, day);
        }

        public static DateTime ToMiladi(this DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.ToDateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0, 0);
        }

        public static DateTime ToDateTime(this string dateTime)
        {
            if (dateTime.Contains("0000/00/00"))
            {
                dateTime = MinDateTime();
            }
            if (dateTime.Contains("9999/99/99"))
            {
                dateTime = MaxDateTime();
            }
            return DateTime.Parse(dateTime);
        }

        public static string MaxDateTime()
        {
            return "1500/01/01 23:59";
        }

        public static string MinDateTime()
        {
            return "1300/01/01 00:01";
        }


        /// <summary>
        /// Gets current shamsi date and time like: 11/1/1111 16:18:20
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentDateTime()
        {
            var gregorianDate = DateTime.Now;
            var persianCalendar = new PersianCalendar();

            var currentDateTime = string.Format("{0}/{1}/{2} {3}:{4}",
                      persianCalendar.GetYear(gregorianDate),
                      persianCalendar.GetMonth(gregorianDate),
                      persianCalendar.GetDayOfMonth(gregorianDate),
                      persianCalendar.GetHour(gregorianDate),
                      persianCalendar.GetMinute(gregorianDate));

            return currentDateTime.ToString();
        }

        /// <summary>
        /// Gets current shamsi date like: 11/1/1111
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentDate()
        {
            var gregorianDate = DateTime.Now;
            var persianCalendar = new PersianCalendar();

            var currentDate = string.Format("{0}/{1}/{2}",
                      persianCalendar.GetYear(gregorianDate),
                      persianCalendar.GetMonth(gregorianDate),
                      persianCalendar.GetDayOfMonth(gregorianDate));


            return currentDate.ToString();
        }

        /// <summary>
        /// Gets current shamsi time like: 16:18:20
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentTime()
        {
            var gregorianDate = DateTime.Now;
            var persianCalendar = new PersianCalendar();

            var currentTime = string.Format("{0}/{1}/{2}",
                      persianCalendar.GetHour(gregorianDate),
                      persianCalendar.GetMinute(gregorianDate),
                      persianCalendar.GetSecond(gregorianDate));


            return currentTime.ToString();
        }


        /// <summary>
        /// Gets persian day of week
        /// </summary>
        /// <returns></returns>
        public static string GetDayOfWeek()
        {
            var gregorianDate = DateTime.Now;
            var persianCalendar = new PersianCalendar();

            var dayOfWeek = persianCalendar.GetDayOfWeek(gregorianDate);

            //TODO: Gaurd against null

            return CalculateDayOfWeek(dayOfWeek);
        }

        /// <summary>
        /// Get full date like: دوشنبه، 1/11/1111
        /// </summary>
        /// <returns></returns>
        public static string GetFullDate()
        {
            var gregorianDate = DateTime.Now;
            var persianCalendar = new PersianCalendar();
            var dayOfWeek = persianCalendar.GetDayOfWeek(gregorianDate);

            var fullDate = string.Format("{0}, {1}/{2}/{3}",
                      CalculateDayOfWeek(dayOfWeek),
                      persianCalendar.GetDayOfWeek(gregorianDate),
                      persianCalendar.GetYear(gregorianDate),
                      persianCalendar.GetMonth(gregorianDate),
                      persianCalendar.GetDayOfMonth(gregorianDate));

            return fullDate.ToString();
        }


        /// <summary>
        /// Gets full date and time like: دوشنبه, 1/11/1111 9:11:36
        /// </summary>
        /// <returns></returns>
        public static string GetFullDateTime()
        {
            var gregorianDate = DateTime.Now;
            var persianCalendar = new PersianCalendar();
            var dayOfWeek = persianCalendar.GetDayOfWeek(gregorianDate);

            var fullDateTime = string.Format("{0}, {1}/{2}/{3} {4}:{5}:{6}",
                      CalculateDayOfWeek(dayOfWeek),
                      persianCalendar.GetYear(gregorianDate),
                      persianCalendar.GetMonth(gregorianDate),
                      persianCalendar.GetDayOfMonth(gregorianDate),
                      persianCalendar.GetHour(gregorianDate),
                      persianCalendar.GetMinute(gregorianDate),
                      persianCalendar.GetSecond(gregorianDate));

            return fullDateTime.ToString();
        }

        private static string CalculateDayOfWeek(DayOfWeek dayOfWeek)
        {
            string currentDay = string.Empty;
            switch (dayOfWeek)
            {
                case DayOfWeek.Saturday:
                    currentDay = "شنبه";
                    break;
                case DayOfWeek.Sunday:
                    currentDay = "یکشنبه";
                    break;
                case DayOfWeek.Monday:
                    currentDay = "دوشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    currentDay = "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    currentDay = "چهارشنبه";
                    break;
                case DayOfWeek.Thursday:
                    currentDay = "پنچشنبه";
                    break;
                case DayOfWeek.Friday:
                    currentDay = "جمعه";
                    break;
            }

            return currentDay;
        }
    }
}
