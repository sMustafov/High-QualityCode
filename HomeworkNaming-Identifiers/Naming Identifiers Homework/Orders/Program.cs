using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using o;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var mapper = new DataMapper();
            var categories = mapper.GetAllCategories();
            var products = mapper.GetAllProducts();
            var orders = mapper.GetAllOrders();

            // Names of the 5 most expensive products
            PrintMostExpensiveProducts(products);

            // Number of products in each category
            PrintNumberOfProducts(products, categories);

            // The 5 top products (by order quantity)
            PrintMostOrderedByQuantity(orders, products);

            // The most profitable category
            PrintTheMostProfitableCategory(orders, products, categories);
        }

        private static void PrintTheMostProfitableCategory(IEnumerable<order> orders, IEnumerable<product> products, IEnumerable<category> categories)
        {
            var category = orders
                .GroupBy(o => o.ProductId)
                .Select(g => new
                {
                    catId = products.First(p => p.Id == g.Key).CategoryId,
                    price =
                        products.First(p => p.Id == g.Key).UnitPrice,
                    quantity = g.Sum(p => p.Quantity)
                })
                .GroupBy(gg => gg.catId)
                .Select(grp => new
                {
                    category_name = categories.First(c => c.Id == grp.Key).Name,
                    total_quantity = grp.Sum(g => g.quantity*g.price)
                })
                .OrderByDescending(g => g.total_quantity)
                .First();
            Console.WriteLine("{0}: {1}", category.category_name, category.total_quantity);
        }

        private static void PrintMostOrderedByQuantity(IEnumerable<order> orders, IEnumerable<product> products)
        {
            var mostOrderedByQuantity = orders
                .GroupBy(o => o.ProductId)
                .Select(grp => new
                {
                    Product = products.First(p => p.Id == grp.Key).Name,
                    Quantities = grp.Sum(grpgrp => grpgrp.Quantity)
                })
                .OrderByDescending(q => q.Quantities)
                .Take(5);
            foreach (var item in mostOrderedByQuantity)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', 10));
        }

        private static void PrintNumberOfProducts(IEnumerable<product> products, IEnumerable<category> categories)
        {
            var numberOfProducts = products
                .GroupBy(p => p.CategoryId)
                .Select(grp => new {Category = categories.First(c => c.Id == grp.Key).Name, Count = grp.Count()})
                .ToList();
            foreach (var item in numberOfProducts)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));
        }

        private static void PrintMostExpensiveProducts(IEnumerable<product> products)
        {
            var mostExpensiveProducts = products
                .OrderByDescending(p => p.UnitPrice)
                .Take(5)
                .Select(p => p.Name);
            Console.WriteLine(string.Join(Environment.NewLine, mostExpensiveProducts));

            Console.WriteLine(new string('-', 10));
        }
    }
}
