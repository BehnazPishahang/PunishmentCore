using System.Globalization;

namespace Utility.DateTimeUtility
{
    public static class DateTimeUtility
    {
        public static DateTime DateTimeNow()
        {
            return DateTime.Now.toPersianDate();
        }

        public static string toPersian(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(dt);
            int month = pc.GetMonth(dt);
            int day = pc.GetDayOfMonth(dt);
            int hour = pc.GetHour(dt);
            int min = pc.GetMinute(dt);

            DateTime PersianDateTime = new DateTime(year, month, day, hour, min, 0);

            return PersianDateTime.ToString("yyyy/MM/dd HH:mm");
        }

        public static DateTime toPersianDateTime(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(dt);
            int month = pc.GetMonth(dt);
            int day = pc.GetDayOfMonth(dt);
            int hour = pc.GetHour(dt);
            int min = pc.GetMinute(dt);

            return new DateTime(year, month, day, hour, min, 0);
        }

        public static DateTime toPersianDate(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(dt);
            int month = pc.GetMonth(dt);
            int day = pc.GetDayOfMonth(dt);

            return new DateTime(year, month, day);
        }

        public static DateTime toMiladi(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.ToDateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, 0, 0);
        }

        public static DateTime toDateTime(this string dt)
        {
            return DateTime.Parse(dt);
        }

    }
}
