using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseWork.Product
{
    public class ProductService : IProductService
    {
        private DataBase.DataBase DB;

        public ProductService()
        {
            DB = new DataBase.DataBase();
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

        public void FillDB()
        {
            CreateProduct("Flower pot", 17.99f,
                "Round ceramic flowerpot for your cosy house. Available in several sizes.", 10);
            CreateProduct("Bath towel", 6.99f,
                "Extra absorbent cotton towel, very wash resistant - will serve you for years.", 3);
            CreateProduct("Irregular shaper candle", 19.99f,
                "Candle with an irregular design. Burns up to 30 hours.", 1);
            CreateProduct("Wool stripped rug", 52.99f,
                "Rectangular wool rug in a combination of colours. A perfect for dull floor designs.", 16);
            CreateProduct("Bar hand soap", 12.99f,
                "Rectangular hand and body perfumed soap bar. It will hide all your naughties consequences", 13);
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

        public List<Product> GetAllProducts()
        {
            return DB.Products.Select(x => x).ToList();
        }

        public void ChangeAmount(string productName, int newAmount)
        {
            var product = GetProduct(productName);
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
            product.Price = newPrice;
        }
    }
}