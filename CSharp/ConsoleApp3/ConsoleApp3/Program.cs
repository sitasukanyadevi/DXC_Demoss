namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter celcius:");
            int c=Convert.ToInt32(Console.ReadLine());
            int f = ((c * 9) / 5)+ 32;
            Console.WriteLine("Fahrenheit of given celcius is " + f);
        }
    }
}