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
            Console.WriteLine("1. Celsius to fahrenhiet");
            Console.WriteLine("2. Fahrenhiet to celsius");
            Console.Write("Please chose a number from the menu:");
            menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    Console.Write("Please enter a celsius:");
                    c = Convert.ToDouble(Console.ReadLine());
                    f = 9 / 5 * c + 32;
                    Console.WriteLine($"{c} celsius is {f} fahrenheit" );
                    Console.Write("please enter any key to exit");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Write("Please enter a fahrenheit");
                    f = Convert.ToDouble(Console.ReadLine());
                    c = 9 / 5 * (f - 32);
                    Console.WriteLine(c);
                    Console.Write("please enter any key to exit");
                    Console.ReadKey();
                    break;
                default:
                    Console.Write("please enter a number from the menu");
                    break;
            }

        }
    }
}
