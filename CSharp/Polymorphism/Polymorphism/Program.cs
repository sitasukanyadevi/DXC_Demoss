/*using System;
namespace Polymorphism
{
    class Overloading {
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
        public int Add(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3);
        }
        public float Add(float num1, float num2)
        {
            return (num1 + num2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Overloading obj = new Overloading();
            Console.WriteLine("Add with two int parameter :" + obj.Add(3,2));
            Console.WriteLine("Add with three int parameter :" + obj.Add(3,2,8));
            Console.WriteLine("Add with two float parameter :" + obj.Add(3f,22f));
        }
    }
}
*/

using System;
namespace Polymorphsim
{
    class Person
    {
        public virtual void Show()
        {
            Console.WriteLine("This is show method of Person class");
        }
    }
    class Student : Person
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("This is show method of Student class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Student();
            p.Show();
        }
    }
}