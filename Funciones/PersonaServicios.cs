using Ejemplodeifelse2.Entities;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplodeifelse2.Funciones
{
    public class PersonaServicios
    {
        // crud
        public void CreatePersona(Persona persona)
        {
            Persona reques = new Persona();

            reques.Nombre = persona.Nombre;
            reques.Apellido = persona.Apellido;
            reques.Correo = persona.Correo;
            reques.edad = persona.edad;

            reques.FKCiudad = persona.FKCiudad;


            using (var _context = new AplicationDBContext())
            {// se abrio la conexion a la base de datos
                
                _context.Personas.Add(reques);
                _context.SaveChanges();//se guardan los cambios



            }// se cerro la conexion
        }

        public List<Persona> GetAllPersona()
        {
            return new List<Persona>();
        }

        public Persona ByIDPersona(int PkPersona)
        {
            Persona persona = new Persona();
            return persona;
        }

        public void UpdatePersona (Persona persona)
        {

        }

        public void DeletePersona(int PkPersona)
        {

        }
        

    }
}
