using MyLibrary;
using System.Net.Http.Headers;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice from 1 to 4:");
            int c = Convert.ToInt16(Console.ReadLine());
            Calculator calc = new Calculator();
            switch (c)
            {
                case 1:
                    {
                        Console.WriteLine(calc.Sum(100, 30));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(calc.Substract(150, 20));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(calc.Multiply(160, 40));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(calc.Division(200, 50));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong Choice, Enter Again");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}