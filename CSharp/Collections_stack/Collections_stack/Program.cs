using System.Collections;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(65);
            s.Push(25);
            s.Push(12);
            s.Push(21);

            Console.WriteLine(s.Contains(30));

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After Remove with Pop Method");
            Console.WriteLine($"{s.Pop()} is popped out");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}