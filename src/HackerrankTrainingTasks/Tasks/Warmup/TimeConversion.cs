using System;
using System.Globalization;

namespace Tasks.Warmup
{
    public class TimeConversion
    {
        public string solution(string twelveHourFormatDate)
        {
            DateTime twentyFourHourFormatDate;

            if (DateTime.TryParseExact(twelveHourFormatDate, "hh:mm:sstt", CultureInfo.InvariantCulture, DateTimeStyles.None, out twentyFourHourFormatDate))
            {
                return twentyFourHourFormatDate.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
            }

            throw new ArgumentException("Invalid date argument format.");
        }
    }
}
