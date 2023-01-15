using System;
using CourseWork.Product;

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
            return " 1. Add products to the store";
        }

        public void DoAction() // TODO safe parsing
        {
            AddProduct();
        }

        private void AddProduct()
        {
            var ps = new ProductService(DB);
            ps.AddProduct();
        }
    }
}