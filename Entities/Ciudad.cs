﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplodeifelse2.Entities
{
    public class Ciudad
    {
        [Key]
        public int PKCiudad { get; set; }
        public string Nombre { get; set; } 
        


    }
}
