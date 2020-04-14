using System.Globalization;
using System;

namespace DateModifier
{
    public static class DateModifier
    {
        public static int GetDaysBetweenDates(string firstDate, string secondDate)
        {
            var dateOne = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var dateTwo = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            if (dateTwo < dateOne)
            {
                return GetDaysBetweenDates(secondDate, firstDate);
            }

            return (dateTwo - dateOne).Days;
        }
    }
}
