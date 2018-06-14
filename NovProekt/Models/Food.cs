using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NovProekt.Models
{
    public class Food
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Ime { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public int Cena { get; set; }
        [Required]
        [StringLength(5000)]
        [Display(Name="Slika")]
        public string Url { get; set; }
        [Display(Name ="Restoran")]
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

    }
}