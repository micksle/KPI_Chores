using System.Collections.Generic;

namespace CourseWork.User
{
    public class DataBase
    {
        private List<User> users;

        public DataBase()
        {
            users = new List<User>();
        }

        public void Add(User user)
        {
            users.Add(user);
        }
        
        public List<User> Get()
        {
            // Users.ForEach(x => Console.WriteLine(x.UserName.Equals(userName)));
            return users;
        }

        public void Delete(User user)
        {
            users.Remove(user);
        }
    }
}