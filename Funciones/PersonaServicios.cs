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



            }// se cerrot la conexion
        }

        public List<Persona> GetAllPersona()
        {
            List<Persona> personalist = new List<Persona>();

            using (var _context = new AplicationDBContext())
            {
                
                personalist = _context.Personas.ToList();
            }
            return personalist;
        }

        public Persona ByIDPersona(int PkPersona)
        {
            Persona persona = new Persona();

            using (var _context = new AplicationDBContext())
            {
                persona = _context.Personas.FirstOrDefault(x => x.PKPersona == PkPersona);
            }
            return persona;
        }

        public void UpdatePersona (Persona nuevo)
        {
            Persona persona = new Persona();

            using (var _context = new AplicationDBContext())
            {
                //uso de find igual a el de persona by id
                persona = _context.Personas.Find(nuevo.PKPersona);

                persona.Nombre = nuevo.Nombre;
                persona.Apellido = nuevo.Apellido;
                persona.Correo = nuevo.Correo;
                persona.edad = nuevo.edad;
                persona.FKCiudad = nuevo.FKCiudad;

                _context.Personas.Update(persona);
                _context.SaveChanges();
            }
            Console.WriteLine("Se actualizo correctamente");
           

        }

        public void DeletePersona(Persona idpersona)
        {
            Persona persona = new Persona();

            using (var _context = new AplicationDBContext())
            {
                //uso de find igual a el de persona by id
                persona = _context.Personas.Find(idpersona.PKPersona);

                _context.Personas.Remove(persona);
                _context.SaveChanges();
            }
        }
        

    }
}
