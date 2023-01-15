using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CourseWork.DataBase
{
    public class ParseInfo
    {
        private string FilePath =
            @"C:\Users\mickle\RiderProjects\KPI_Chores\3rd term\Object-oriented programming\CourseWork\DataBase\Files\";

        // public void SaveToDB(User.User user)
        // {
        //     // var products = ReadProductsFromDB();
        //     var path = string.Concat(FilePath, "Users.json");
        //     var products = new List<User.User>();
        //     products.Add(user);
        //     Console.WriteLine("i`m here");
        //     var serialized = JsonConvert.SerializeObject(products);
        //     File.WriteAllText(path, serialized);
        // } //todo redundant?

        public void SaveAllProductsToDB(List<Product.Product> products)
        {
            var path = string.Concat(FilePath, "Products.json");
            var serialized = JsonConvert.SerializeObject(products);
            File.WriteAllText(path, serialized);
        }

        public void SaveAllUsersToDB(List<User.User> users)
        {
            var path = string.Concat(FilePath, "Users.json");
            var serialized = JsonConvert.SerializeObject(users);
            File.WriteAllText(path, serialized);
        }

        public List<Product.Product> ReadProductsFromDB()
        {
            var path = string.Concat(FilePath, "Products.json");
            var products = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Product.Product>>(products);
        }

        public List<User.User> ReadUsersFromDB()
        {
            var path = string.Concat(FilePath, "Users.json");
            var users = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<User.User>>(users);
        }
    }
}