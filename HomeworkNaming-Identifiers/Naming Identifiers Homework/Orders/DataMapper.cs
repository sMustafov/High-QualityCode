using System.Collections.Generic;
using System.Linq;
using o;
using System.IO;

namespace Orders
{
    public class DataMapper
    {
        private string categoriesFileName;
        private string productsFileName;
        private string ordersFileName;

        public DataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this.CategoriesFileName = categoriesFileName;
            this.ProductsFileName = productsFileName;
            this.OrdersFileName = ordersFileName;
        }

        public DataMapper()
            : this("../../Data/categories.txt", "../../Data/products.txt", "../../Data/orders.txt")
        {
        }

        public string CategoriesFileName { get; set; }

        public string ProductsFileName { get; set; }

        public string OrdersFileName { get; set; }

        public IEnumerable<category> GetAllCategories()
        {
            var category = ReadFileLines(this.CategoriesFileName, true);
            return category
                .Select(c => c.Split(','))
                .Select(c => new category
                {
                    Id = int.Parse(c[0]),
                    Name = c[1],
                    Description = c[2]
                });
        }

        public IEnumerable<product> GetAllProducts()
        {
            var product = ReadFileLines(this.productsFileName, true);
            return product
                .Select(p => p.Split(','))
                .Select(p => new product
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    CategoryId = int.Parse(p[2]),
                    UnitPrice = decimal.Parse(p[3]),
                    UnitsInStock = int.Parse(p[4]),
                });
        }

        public IEnumerable<order> GetAllOrders()
        {
            var order = ReadFileLines(this.ordersFileName, true);
            return order
                .Select(p => p.Split(','))
                .Select(p => new order
                {
                    ID = int.Parse(p[0]),
                    ProductId = int.Parse(p[1]),
                    Quantity = int.Parse(p[2]),
                    Discount = decimal.Parse(p[3]),
                });
        }

        private List<string> ReadFileLines(string filename, bool hasHeader)
        {
            var allLines = new List<string>();
            using (var reader = new StreamReader(filename))
            {
                string currentLine;
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allLines.Add(currentLine);
                }
            }

            return allLines;
        }
    }
}
