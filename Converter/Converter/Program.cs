using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Liters");
            int liters = 0;
            int.TryParse(Console.ReadLine(), out liters);

            Console.WriteLine("1) for Fluid ounce (fl oz)\n2) for Gill(gl)\n3) for Pint (pt)\n4) for Quart (qt)\n5) for Gallon (gal)\n6) for Tablespoon (tbsp)\n7) for Teaspoon (tsp)\n8) for Cup");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            
            switch (num)
            {
                case 1:
                    Console.WriteLine(liters *  33.814  + " Fluid ounce (fl oz)");
                    break;
                    case 2:
                    Console.WriteLine(liters *  8.454  + " Gill(gl)");
                    break;
                    case 3:
                    Console.WriteLine(liters *  2.113  + " Pint (pt)");
                    break;
                    case 4:
                    Console.WriteLine(liters *  1.057  + " Quart (qt)");
                    break;
                    case 5:
                    Console.WriteLine(liters /  3.785  + " Gallon (gal)");
                    break;
                    case 6:
                    Console.WriteLine(liters *  67.628  + " Tablespoon (tbsp)");
                    break;
                    case 7:
                    Console.WriteLine(liters *  202.884  + " Teaspoon (tsp)");
                    break;
                    case 8:
                    Console.WriteLine(liters *  4.227  + " Cup");
                    break;
                    default:
                    Console.WriteLine("Invalid Unit");
                    break;
            }
            Console.ReadLine();

            /*if (num == 1)
            {
                Console.WriteLine(meters *  3.281  + " feet");
            }
            if (num == 2)
            {
                Console.WriteLine(meters *  1.094  + " yards");
            }*/

        }
    }
}
