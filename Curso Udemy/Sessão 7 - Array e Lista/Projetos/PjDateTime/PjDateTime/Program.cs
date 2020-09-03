using System;
using System.Globalization;

namespace PjDateTime {
    class Program {
        static void Main(string[] args) {

            /*DateTime d1 = new DateTime(2020, 06, 23, 23, 03, 03, 12, 00);

            DateTime d2 = DateTime.Parse("2000-08-15");

            DateTime d3 = DateTime.ParseExact("23-06-2020", "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime d4 = new DateTime(2020, 06, 24, 12, 45, 00);*/

            DateTime dLocal = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime dUtc = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime data = DateTime.Parse("2000-08-25 13:05:58");
            DateTime data2 = DateTime.Parse("2000-08-25T13:05:58Z");

            /*Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4.Date);
            Console.WriteLine(d4.DayOfWeek);
            Console.WriteLine(d4.ToLongDateString());
            Console.WriteLine(d4.AddDays(2));*/

            Console.WriteLine(dLocal.ToLocalTime());
            Console.WriteLine(dUtc.ToUniversalTime());
            Console.WriteLine(data2.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Console.WriteLine(data2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
