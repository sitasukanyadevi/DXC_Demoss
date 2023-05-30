using System;
using System.Collections;
using System.Xml.Linq;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();
            list.Add(3, "Three");
            list.Add(5, "Five");
            list.Add(4, "Four");
            list.Add(1, "One");
            list.Add(2, "Two");
            foreach (var i in list.Keys)
            {
                Console.WriteLine($"Key: {i}, Value: {list[i]}");
            }
     
            //This method is used to removes the element at the specified index of a SortedList object.
            list.RemoveAt(2);
            foreach (var i in list.Keys)
            {
                Console.WriteLine($"Key: {i}, Value: {list[i]}");
            }
            //It display index value of given key 
            Console.WriteLine(list.GetKey(0));
        }
    }
}