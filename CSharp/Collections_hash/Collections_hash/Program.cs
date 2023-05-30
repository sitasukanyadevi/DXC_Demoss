using System.Collections;
namespace Collections_hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(3, "three");
            ht.Add(5, "Five");
            ht.Add(2, "Two");
            ht.Add(1, "One");
            ht.Add(4, "Four");
            foreach(object i in ht.Keys)
            {
                Console.WriteLine($"{i} and {ht[i]}");
            }
            
        }
    }
}