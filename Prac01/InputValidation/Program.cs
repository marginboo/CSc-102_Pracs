﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How often do you hear a drip in (in seconds)");
            string rates = Console.ReadLine();

            int rate;

            if (Int32.TryParse(rates , out rate )) { Console.WriteLine(" Invalid input"); Console.ReadLine(); }

            rate = Convert.ToInt32(rates);
            double day = 86400 / rate * 0.00025;
            double glass = day / 0.25;

            Console.WriteLine("This wastes " + glass + " cups of water every day");
            Console.ReadLine();
        }
    }
}
