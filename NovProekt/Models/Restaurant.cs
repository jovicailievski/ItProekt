using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NovProekt.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Ime { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        [Display(Name = "Slika")]
        public string Url { get; set; }
        //public double Rating { get; set; }
        public int Kapacitet { get; set; }
        public ICollection<Food> Food { get; set; }
    }
}