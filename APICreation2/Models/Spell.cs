using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APICreation2.Models
{
    public class Spell
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string School { get; set; }
        [Required]
        public int ManaCost { get; set; }

        [Range(0,double.PositiveInfinity)]
        public int Damage { get; set; }
        public string Description { get; set; }
    }
}