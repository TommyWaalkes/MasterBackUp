using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserLoginStoreFront.Models
{
    public class UserDb
    {
        public List<User> Users { get; set; }
        public UserDb()
        {
            Users = new List<User>();
            Users.Add(new User("tommy", "1234Gc", "Tommy@email.com", 27));
            Users.Add(new User("anna", "horsey123","Anna@gmail.co", 26));
        }

        //Create
        public void CreateUser(string name, string password, string email, int age)
        {
            User u = new User(name, password, email, age);
            Users.Add(u);
        }

        //Update
        public void UpdateUser(int ID, User u)
        {
            try
            {
                Users[ID] = u;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        //Destroy
        public void DeleteUser(int ID)
        {
            Users.RemoveAt(ID);
        }

        //Get 
        public User GetUser(int ID)
        {
            return Users[ID];
        }
    }
}