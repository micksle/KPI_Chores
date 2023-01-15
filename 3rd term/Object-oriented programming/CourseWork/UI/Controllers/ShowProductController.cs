using CourseWork.Product;

namespace CourseWork.UI
{
    public class ShowProductController : IControllerInterface
    {
        private DataBase.DataBase DB { get; }

        public ShowProductController(DataBase.DataBase dataBase)
        {
            DB = dataBase;
        }

        public string PrintMessage()
        {
            return " 4. Show available products";
        }

        public void DoAction() // TODO: what if list is empty?
        {
            var ps = new ProductService(DB);
            ps.ShowProducts();
        }
    }
}