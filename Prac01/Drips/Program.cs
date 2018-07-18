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
            Console.WriteLine("How often do you hear a drip drop (in seconds)?");
            string num =Console.ReadLine();
            int number = Convert.ToInt32(num);
            

            
            double hour = 3600/number * 0.00025;
            double day = 86400/number * 0.00025;
            double week = 604800/number * 0.00025;

            Console.WriteLine("This wastes " + hour + " litres of water every hour");
            Console.WriteLine("This wastes " + day + " litres of water every day");
            Console.WriteLine("This wastes " + week + " litres of water every week");
            Console.ReadLine();
        }
    }
}
