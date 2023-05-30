namespace Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int z = 0;
            try
            {
                Console.WriteLine("Enter First Number");
                x = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                y = Convert.ToInt16(Console.ReadLine());
                z = x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide any number by zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers are allowed");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine($"The result is {z}");
                Console.WriteLine("Program End.");
            }
        }
    }
}