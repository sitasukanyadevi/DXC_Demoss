namespace trycatchexception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int z = 0;
            
            try
            {
                Console.WriteLine("Enter x value:");
                x = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter y value:");
                y = Convert.ToInt16(Console.ReadLine());
                z = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Result  is {z}");
        }
    }
}