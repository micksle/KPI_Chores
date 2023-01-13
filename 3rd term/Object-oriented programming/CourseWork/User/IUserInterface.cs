using System;

namespace CourseWork.User
{
    public interface IUserInterface
    {
        void CreateUser(string userName);
        User GetUserByID(Guid id);
        Guid GetUser(string userName);
        void DeleteUser(string userName);
        bool IsUser(string userName);
        void GetAllUsers();
    }
}