using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CourseWork.DataBase;

namespace CourseWork.Product
{
    public class ProductService : IProductService
    {
        private DataBase.DataBase DB;

        public ProductService(DataBase.DataBase dataBase)
        {
            DB = dataBase;
        }

        public void CreateProduct(string productName, float price, string description, int amount)
        {
            var product = new Product(productName, price, description, amount);
            DB.Products.Add(product);
            Console.WriteLine("Product " + productName + " created successfully");
        }

        public Product GetProduct(string productName)
        {
            if (ProductExists(productName))
            {
                return DB.Products.Find(x => x.Name.Equals(productName));
            }

            return new Product("unknown", 0, "", 0);
        }

        public void DeleteProduct(string productName)
        {
            if (ProductExists(productName))
            {
                // DB.Products.Remove(DB.Products.Find(x => x.Name.Equals(productName)));
                var product = GetProduct(productName);
                DB.Products.Remove(product);
                Console.WriteLine("Product " + productName + " deleted successfully");
                return;
            }

            Console.WriteLine("Product " + productName + " was not found");
        }

        public List<Product> GetAllProducts()
        {
            return DB.Products.Select(x => x).ToList();
        }
        
        public void GetProductsFromDB()
        {
            var parser = new ParseInfo();
            var products = parser.ReadProductsFromDB();
            foreach (var product in products)
            {
                DB.Products.Add(product);
            }
        }

        public void ShowProducts()
        {
            // GetProductsFromDB();
            DB.Products.ForEach(Console.WriteLine);
        }

        public bool ProductExists(string productName)
        {
            foreach (var product in DB.Products)
            {
                if (product.Name.Equals(productName))
                {
                    return true;
                }
            }

            return false;
        }

        public bool DecreaseAmount(string productName, int amount)
        {
            var product = GetProduct(productName);
            if (product.Amount == 0)
            {
                return false;
            }
            product.Amount -= amount;
            return true;
        }
        
        public void ChangeAmount(string productName, int newAmount)
        {
            var product = GetProduct(productName);
            if (newAmount < 0)
            {
                product.Price = 0;
                return;
            }
            product.Amount = newAmount;
        }

        public void ChangeDescription(string productName, string newDescription)
        {
            var product = GetProduct(productName);
            product.Description = newDescription;
        }

        public void ChangePrice(string productName, float newPrice)
        {
            var product = GetProduct(productName);
            if (newPrice < 0.99)
            {
                product.Price = 0.99f;
                return;
            }
            product.Price = newPrice;
        }
    }
}