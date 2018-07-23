using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drips
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How often do you hear a drip in (in seconds)");
     
            string rates = Console.ReadLine();
            int rate = Convert.ToInt32(rates);

            double hour = 3600 / rate * 0.00025;
            double day = 86400 / rate * 0.00025;
            double week = 604800 / rate * 0.00025;
            
            Console.WriteLine("This wastes " + hour + " litres of water every hour" );
            Console.WriteLine("This wastes " + day + " litres of water every day");
            Console.WriteLine("This wastes " + week + " litres of water every week");

            
            Console.ReadLine();
        }
    }
}
