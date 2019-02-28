using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskListBreakout.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Task
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public bool Complete { get; set; }
        public DateTime DueDate { get; set; }
    }

    public class TaskListContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}