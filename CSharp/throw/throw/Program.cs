namespace Excepthrow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z = 0;
            try
            {
                Console.WriteLine("Enter First Number");
                x = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                y = Convert.ToInt16(Console.ReadLine());
                if (x < y)
                {
                    throw new ownException("Value of first number cannot be less than second number");
                }
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
            catch (ownException e)
            {
                Console.WriteLine(e.Message);
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