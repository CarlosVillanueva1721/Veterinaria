using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Veterinaria.web.Models
{
    public class Veterinary
    {
        public int Id { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        public ICollection<Consult> Consults { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}