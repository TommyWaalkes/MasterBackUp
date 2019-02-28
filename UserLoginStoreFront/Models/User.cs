using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserLoginStoreFront.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public User(string Name, string Password, string Email, int Age)
        {
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.Age = Age;
        }
    }
}