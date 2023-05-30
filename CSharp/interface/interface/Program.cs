using System;

interface IVehiculo
{
    void Drive();
    bool Refuel(int amount);
}

class Car : IVehiculo
{
    private int gasoline;

    public Car(int initialGasoline)
    {
        gasoline = initialGasoline;
    }

    public void Drive()
    {
        if (gasoline > 0)
        {
            Console.WriteLine("The car is driving.");
        }
    }

    public bool Refuel(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Invalid amount.");
            return false;
        }
        gasoline += amount;
        Console.WriteLine("Gasoline refueled. Current gasoline level: " + gasoline);
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the amount of gasoline to refuel: ");
        int amount = Convert.ToInt16(Console.ReadLine());
        Car car = new Car(0);
        car.Refuel(amount);
        car.Drive();
    }
}