namespace Linkdemo2
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name="Laptop", Brand="Dell", Quantity=5, Price=46500},
                new Product { Id = 2, Name="Camera", Brand="Canon", Quantity=7, Price=32300},
                new Product { Id = 3, Name="Tablet", Brand="Lenovo", Quantity=2, Price=18500},
                new Product { Id = 4, Name="Desktop", Brand="HP", Quantity=9, Price=78200},
                new Product { Id = 5, Name="Earphones", Brand="Boat", Quantity=3, Price=3000},
                new Product { Id = 6, Name="Mobile", Brand="Apple", Quantity=4, Price=84000},
            };

            //var query = from x in products where x.Id == 3 select x;
            //foreach (var item in query)
            //{ 
            //  Console.WriteLine($"{item.Id} {item.Name} {item.Brand} {item.Quantity} {item.Price}");
            //}


            //.....where method

            //var result = products.Where(x => x.Id == 4).ToList(); ;         
            //foreach (var i in result)
            //{ 
            //    Console.WriteLine($"{i.Id} {i.Name} {i.Brand} {i.Quantity} {i.Price}");
            //}

            //.....

            //var item = products.Where(x => x.Price == products.Min(p => p.Price)).FirstOrDefault();
            //Console.WriteLine($"{item.Id} {item.Name} {item.Brand} {item.Quantity} {item.Price}");

            var item = products.Where(x => x.Price == products.Max(p => p.Price)).FirstOrDefault();
            Console.WriteLine($"{item.Id} {item.Name} {item.Brand} {item.Quantity} {item.Price}");


        }
    }
}