namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t;
            double p,r,si;
            Console.WriteLine("Enter principle amount");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Time");
            t = Convert.ToInt16(Console.ReadLine());
            si = p * r * t / 100;
            Console.WriteLine(si);
        }
    }
}