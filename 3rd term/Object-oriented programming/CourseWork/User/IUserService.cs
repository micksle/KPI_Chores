using System.Collections.Generic;

namespace CourseWork.User
{
    public interface IUserService
    {
        void CreateUser(string userName);
        User GetUser(string userName);
        void DeleteUser(string userName);
        bool UserExists(string userName);
        void PrintAllUsers();
        List<Purchase.PurchaseHistory> GetHistory(string userName);
        void IncreaseBalance(string userName, float amount);
        void DecreaseBalance(string userName, float amount);
    }
}