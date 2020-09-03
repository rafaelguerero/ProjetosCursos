using PjDiamante.Devices;
using System;

namespace PjDiamante
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1020};
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() {SerialNumber = 8090 };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() {SerialNumber = 45789 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
