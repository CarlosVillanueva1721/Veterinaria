using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veterinaria.web.Models
{
    public class History
    {
        public int Id { get; set; }
        public Consult Consult { get; set; }
    }
}