namespace prjInventoryManagement
{
     class Program
    {
        static void Main()
        {
            var products = new List<Product>
        {
            new Product { Id=1, Name="Red Wine", Quantity=12, Price=129.99m },
            new Product { Id=2, Name="Champagne",     Quantity=4,  Price=1499.00m },
            new Product { Id=3, Name="Whiskey",       Quantity=25, Price=249.50m },
            new Product { Id=4, Name="Cognac",    Quantity=3,  Price=799.00m }
        };


            // Extension method getting called upon
            Console.WriteLine($"Total inventory value: {products.TotalInventoryValue():C}");

            Console.WriteLine("\nLow stock items (<=5):");
            foreach (var p in products.LowStock(5))
                Console.WriteLine(p);

            //LINQ with an anonymous type
            Console.WriteLine("\nName + Price (anonymous type):");
            var nameAndPrice = products.Select(p => new { p.Name, p.Price });
            foreach (var np in nameAndPrice)
                Console.WriteLine($"{np.Name} - {np.Price:C}");

        }
    }
}
