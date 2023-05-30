// See https://aka.ms/new-console-template for more information
int num1, num2, num3;
    Console.WriteLine("Enter the num1 :");
    num1 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter the num2 :");
    num2 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter the num3 :");
    num3 = Convert.ToInt16(Console.ReadLine());
    if (num1 > num2)
    {
        if (num1 > num3)
        {
            Console.WriteLine("The 1st Number is the greatest among three.");
        }
        else
        {
            Console.WriteLine("The 3rd Number is the greatest among three.");
        }
    }
    else if (num2 > num3)
        Console.Write("The 2nd Number is the greatest among three");
    else
        Console.Write("The 3rd Number is the greatest among three");

