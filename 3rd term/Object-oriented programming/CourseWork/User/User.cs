using System;

namespace CourseWork.User
{
    public class User
    {
        public string UserName { get; }
        public Guid Id { get; }

        public User(string userName)
        {
            Id = Guid.NewGuid();
            UserName = userName;
        }

        public override string ToString()
        {
            return "User`s name: " + UserName;
        }
    }
}