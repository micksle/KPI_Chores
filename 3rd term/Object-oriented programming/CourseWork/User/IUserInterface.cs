using System;

namespace CourseWork.User
{
    public interface IUserInterface
    {
        void CreateUser(string userName);
        User GetUserByID(Guid id);
        User GetUser(string userName);
        void DeleteUser(string userName);
        bool UserExists(string userName);
        void GetAllUsers();
    }
}