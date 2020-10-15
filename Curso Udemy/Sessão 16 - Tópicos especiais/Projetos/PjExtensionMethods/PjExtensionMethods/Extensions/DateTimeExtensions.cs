using System;
using System.Collections.Generic;
using System.Globalization;

namespace PjExtensionMethods.Extensions
{
    static class DateTimeExtensions
    {
        //this é uma referência pra o próprio objeto
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now - thisObj;

            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hour(s).";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " day(s).";
            }
        }
    }
}
