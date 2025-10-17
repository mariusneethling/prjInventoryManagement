using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    public static class ProductListExtensions
    {
        // This is for the total value of all products 
        public static decimal TotalInventoryValue(this List<Product> products) =>
            products.Sum(p => p.Quantity * p.Price);

        // This is to filter the products that are low in stock 
        //Reference: MicrosoftLearn (2025).
        //Write C# LINQ queries to query data 
        public static IEnumerable<Product> LowStock(this List<Product> products, int threshold = 5) =>
            products.Where(p => p.Quantity <= threshold);

    }
}
/*
 * Reference List: 
 * MicrosfoftLearn. 18 January 2025. Write C# LINQ queries to query data. (Version 8.0). [Sourcecode]. https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/write-linq-queries. (Accessed 17 October 2025).
 * 
 */