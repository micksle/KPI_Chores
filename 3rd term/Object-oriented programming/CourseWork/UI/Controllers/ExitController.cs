using System;

namespace CourseWork.UI
{
    public class ExitController : IControllerInterface
    {
        private DataBase.DataBase DB { get; }

        public ExitController(DataBase.DataBase dataBase)
        {
            DB = dataBase;
        }
        public string PrintMessage()
        {
            return " 5. Stop the program";
        }

        public void DoAction()
        {
            var dataBaseControllerController = new DataBaseController(DB);
            dataBaseControllerController.CloseDB();
            throw new Exception("\n----Stopping the program----\n");
        }
    }
}