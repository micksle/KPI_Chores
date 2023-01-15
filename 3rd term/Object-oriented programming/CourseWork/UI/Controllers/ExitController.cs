using System;

namespace CourseWork.UI
{
    public class ExitController : IControllerInterface
    {private DataBase.DataBase DB { get; }

        public ExitController(DataBase.DataBase dataBase)
        {
            DB = dataBase;
        }
        public string PrintMessage()
        {
            return " - stop the program";
        }

        public void DoAction()
        {
            DataBaseController DBController = new DataBaseController(DB);
            DBController.CloseDB();
            throw new Exception("\n----Stopping the program----\n");
        }
    }
}