using System.Collections.Generic;

namespace CourseWork.Product
{
    public class DataBase
    {
        private List<Product> Products;

        public DataBase()
        {
            Products = new List<Product>();
        }

        public void Add(Product user)
        {
            Products.Add(user);
        }
        
        public List<Product> Get()
        {
            // Users.ForEach(x => Console.WriteLine(x.UserName.Equals(userName)));
            return Products;
        }

        public void Delete(Product user)
        {
            Products.Remove(user);
        }
    }
}