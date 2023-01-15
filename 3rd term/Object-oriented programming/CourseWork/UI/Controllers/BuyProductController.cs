using CourseWork.Purchase;

namespace CourseWork.UI
{
    public class BuyProductController : IControllerInterface
    {
        private DataBase.DataBase DB { get; }

        public BuyProductController(DataBase.DataBase dataBase)
        {
            DB = dataBase;
        }

        public string PrintMessage()
        {
            return " - buy products";
        }

        public void DoAction()
        {
            var ps = new PurchaseService(DB);
            ps.Buy();
        }
    }
}