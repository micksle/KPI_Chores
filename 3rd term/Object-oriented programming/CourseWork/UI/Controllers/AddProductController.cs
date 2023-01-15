using System;

namespace CourseWork.UI
{
    public class AddProductController : IControllerInterface
    {
        private DataBase.DataBase DB { get; }

        public AddProductController(DataBase.DataBase dataBase)
        {
            DB = dataBase;
        }

        // TODO add safe-add method / buy product controller?
        public string PrintMessage()
        {
            return " - add products to the store";
        }

        public void DoAction() // TODO safe parsing
        {
            AddProduct();
        }

        private void AddProduct()
        {
            Console.WriteLine("Add the name of the product");
            var name = Console.ReadLine();
            Console.WriteLine("Add the price of the product");
            var price = float.Parse(Console.ReadLine());
            Console.WriteLine("Add the description of the product");
            var description = Console.ReadLine();
            Console.WriteLine("Add the amount of the product");
            var amount = int.Parse(Console.ReadLine());

            var product = new Product.Product(name, price, description, amount);
            DB.Products.Add(product);
        }
    }
}