using System;

namespace CelsiusFahrenheitCoverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double f;
            double c;
            string menu;
            Console.Write("1. Celsius to fahrenhiet");
            Console.Write("2. Fahrenhiet to celsius");
            Console.Write("Please chose a number from the menu");
            menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    Console.Write("Please enter a celsius");
                    c = Convert.ToDouble(Console.ReadLine());
                    f = 9 / 5 * c + 32;
                    Console.Write($"{c} celsius is {f} fahrenheit" );
                        break;
                case "2":
                    Console.Write("Please enter a fahrenheit");
                    f = Convert.ToDouble(Console.ReadLine());
                    c = 9 / 5 * (f - 32);
                    break;
                default:
                    break;
            }

        }
    }
}
