
using System;

namespace SwitchCaseexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float principle, rate, time, si, area, radius, c, cel, fah;
            char choice;

            do
            {
                Console.WriteLine("1. Simple Interest");
                Console.WriteLine("2. Area of Circle");
                Console.WriteLine("3. Circumference of Circle");
                Console.WriteLine("4. Celsius to Fahrenheit");

                Console.Write("Enter your choice: ");
                int value = Convert.ToInt32(Console.ReadLine());

                switch (value)
                {
                    case 1:
                        Console.Write("Enter Principal: ");
                        principle = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Enter Rate: ");
                        rate = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Enter Time: ");
                        time = Convert.ToSingle(Console.ReadLine());

                        si = (principle * rate * time) / 100;
                        Console.WriteLine("Simple Interest = " + si);
                        break;

                    case 2:
                        Console.Write("Enter Radius: ");
                        radius = Convert.ToSingle(Console.ReadLine());

                        area = 3.14f * radius * radius;
                        Console.WriteLine("Area of Circle = " + area);
                        break;

                    case 3:
                        Console.Write("Enter Radius: ");
                        radius = Convert.ToSingle(Console.ReadLine());

                        c = 2 * 3.14f * radius;
                        Console.WriteLine("Circumference = " + c);
                        break;

                    case 4:
                        Console.Write("Enter Celsius: ");
                        cel = Convert.ToSingle(Console.ReadLine());

                        fah = (cel * 9 / 5) + 32;
                        Console.WriteLine("Fahrenheit = " + fah);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

                Console.Write("Do you want to continue (y/n): ");
                choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'y' || choice == 'Y');
        }
    }
}
