using System;

namespace PjTimeSpan {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = TimeSpan.FromDays(3);
            TimeSpan t3 = TimeSpan.FromHours(3);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
        }
    }
}
