using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How often do you hear a drip drop (in seconds)?");
            string num = Console.ReadLine();
            double number = Convert.ToDouble(num);

            double day = 86400 / number * 0.00025;

         
            double ans = day / 0.25;
            Console.WriteLine(Math.Floor(ans) + " full glasses of water are being wasted" );
            Console.ReadLine();


        }
    }
}
