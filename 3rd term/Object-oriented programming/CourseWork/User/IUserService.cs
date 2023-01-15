using System.Collections.Generic;
using CourseWork.Purchase;

namespace CourseWork.User
{
    public interface IUserService
    {
        void CreateUser(string userName, string password);
        User GetUser(string userName);
        void DeleteUser(string userName);
        bool UserExists(string userName);
        void PrintAllUsers();
        List<PurchaseHistory> GetHistory(User user);
        void IncreaseBalance(User user, float amount);
        bool DecreaseBalance(User user, float price, int amount);
    }
}