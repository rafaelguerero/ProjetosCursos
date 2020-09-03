using System;
using System.Collections.Generic;
using System.Text;

namespace PjDiamante.Devices
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner Processing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
