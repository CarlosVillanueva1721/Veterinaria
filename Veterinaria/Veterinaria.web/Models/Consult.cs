using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.web.Models
{
    public class Consult
    {
        public int Id { get; set; }
        [Required]
        [Display (Name="Nombre")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Display(Name = "Apellido")]
        [MaxLength(50)]
        public string LasttName { get; set; }
        [Display(Name = "Dirreccion")]
        [MaxLength(400)]
        public string addres { get; set; }
        [Display(Name = "Telefono")]
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Correo")]
        [MaxLength(50)]
        public string Email { get; set; }
    }
}