using System;
using CourseWork.DataBase;

namespace CourseWork.UI
{
    public class DataBaseController : IControllerInterface
    {
        private DataBase.DataBase DB { get; }
        private ParseInfo Parse { get; }

        public DataBaseController(DataBase.DataBase dataBase)
        {
            Parse = new ParseInfo();
            DB = dataBase;
            DoAction();
        }

        public string PrintMessage()
        {
            return "";
        }

        public void DoAction()
        {
            InvokeProductsDB();
            InvokeUsersDB();
        }

        public void CloseDB()
        {
            SleepProductsDB();
            SleepUsersDB();
        }

        private void InvokeProductsDB()
        {
            var products = Parse.ReadProductsFromDB();
            foreach (var product in products)
            {
                DB.Products.Add(product);
            }
        }

        private void InvokeUsersDB()
        {
            var users = Parse.ReadUsersFromDB();
            foreach (var user in users)
            {
                DB.Users.Add(user);
            } // todo safe method
        }
        
        private void SleepProductsDB()
        {
            Parse.SaveAllProductsToDB(DB);
        }

        private void SleepUsersDB()
        {
            Parse.SaveAllUsersToDB(DB);
        }
    }
}