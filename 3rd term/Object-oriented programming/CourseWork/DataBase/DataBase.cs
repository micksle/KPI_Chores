using System.Collections.Generic;

namespace CourseWork.DataBase
{
    public class DataBase
    {
        public List<User.User> Users { get; }
        public List<Product.Product> Products { get; }
        // public List<Purchase.PurchaseHistory> Purchases { get; }

        public DataBase()
        {
            Users = new List<User.User>();
            Products = new List<Product.Product>();
            // Purchases = new List<Purchase.PurchaseHistory>();
        }
    }
}