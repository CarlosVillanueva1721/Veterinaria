﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Veterinaria.web.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}