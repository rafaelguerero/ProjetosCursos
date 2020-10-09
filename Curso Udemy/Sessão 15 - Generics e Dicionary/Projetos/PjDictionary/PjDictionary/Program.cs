using System.Collections.Generic;
using System;

namespace PjDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> coockies = new Dictionary<string, string>();
            coockies["User"] = "Maria";
            coockies["email"] = "maria@gmail.com";
            coockies["fone"] = "998547815";            

            Console.WriteLine(coockies["fone"]);
            Console.WriteLine(coockies["email"]);

            coockies.Remove("email");
            if (coockies.ContainsKey("email"))
            {
                Console.WriteLine(coockies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine(coockies.Count);
            Console.WriteLine("All coockies");
            foreach (var item in coockies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
