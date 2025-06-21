using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplodeifelse2.Entities;
using Microsoft.Extensions.Options;

namespace Ejemplodeifelse2.Funciones
{
    public class AplicationDBContext: DbContext
    {
        //metodo  para conectarse a la bd
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseMySQL(@"datasource =127.0.0.1; port =3306; username =root; password = ;database=BDPOO;");
            
               
        }

        //mapeo de objetos en bd
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
    }
}
