using System.Collections;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(9);
            list.Add(11);
            list.Add("c#");
            list.Add(9.45f);
            list.Add(false);

            foreach (object i in list)
            {
                Console.WriteLine(i);
            }

            //Capacity is the number of elements that the ArrayList can store.
            Console.WriteLine(list.Capacity);
            //The Count is the number of elements that are actually in the ArrayList.
            Console.WriteLine(list.Count);
            //Gets a value indicating whether the ArrayList has a fixed size.
            Console.WriteLine(list.IsFixedSize);
            //gets value at index 2 
            Console.WriteLine(list[3]);


            list.Insert(2, "World");


            //Console.WriteLine("After Insert");
            //foreach (var i in list)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
