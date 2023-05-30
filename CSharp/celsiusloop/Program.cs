char ch;
    do
    {
        Console.WriteLine("Enter temp in Celsius");
        double Celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Temp in Celsius is {Celsius}");
        double Fahrenheit = ((Celsius * 9) / 5) + 32;
        Console.WriteLine($"Temp in Fahrenheit is {Fahrenheit}");
        Console.WriteLine("do u want to continue?");
        ch = Convert.ToChar(Console.ReadLine());
    }
while (ch == 'y' || ch=='Y');