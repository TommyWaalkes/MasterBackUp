using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICreation.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Category { get; set; }
    }
}