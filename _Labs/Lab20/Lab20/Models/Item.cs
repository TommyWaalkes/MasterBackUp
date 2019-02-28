using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data.Entity;

namespace Lab20.Models
{
    public class Item
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Product { get; set; }
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }

    }

    public class DBItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}