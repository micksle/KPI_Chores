using CourseWork.Purchase;

namespace CourseWork.UI
{
    public class BuyProductController : IControllerInterface
    {
        private DataBase.DataBase DB { get; }
        private User.User User { get; }

        public BuyProductController(DataBase.DataBase dataBase, User.User user)
        {
            DB = dataBase;
            User = user;
        }

        public string PrintMessage()
        {
            return " 2. Buy products";
        }

        public void DoAction()
        {
            var ps = new PurchaseService(DB);
            ps.Buy(User);
        }
    }
}