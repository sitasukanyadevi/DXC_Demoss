namespace Linq_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Banana", "Watermelon", "Pineapple", "Lichi", "Guava", "Avacado", "Cherry", "Apple", "Mango", "Grapes" };
            //var query = from y in fruits select y;
            //var query = from f in fruits where f.Length%2!=0 select f;
            //var query = from x in fruits where x.StartsWith('G') select x;
            //var query = from x in fruits orderby x descending select x;
            var query = from x in fruits orderby x select x;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}