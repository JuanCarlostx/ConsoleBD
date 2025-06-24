// See https://aka.ms/new-console-template for more information
using Ejemplodeifelse2.Entities;
using Ejemplodeifelse2.Funciones;

PersonaServicios servicios = new PersonaServicios();

Console.WriteLine("Hello, World!");
Console.WriteLine( "Ingrese su edad");

Console.WriteLine("Ingresa una de las siguientes opciones");
Console.WriteLine( "1. Listar persona");
Console.WriteLine( "2. Crear persona");
Console.WriteLine("3. Actualizar persona");
Console.WriteLine("4. Eliminar persona");
Console.WriteLine("5. Buscar por id");

int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Has seleccionado ver la lista");
        //uso del for each para recorrer la lista de personas
        List<Persona> Listap = new List<Persona>();
        Listap = servicios.GetAllPersona();

        foreach (var item in Listap)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("ID >> "+ item.PKPersona);
            Console.WriteLine("Nombre >> " + item.Nombre);
            Console.WriteLine("Apellido >> " + item.Apellido);
            Console.WriteLine("Correo >> " + item.Correo);
            Console.WriteLine("Edad >> " + item.edad);

            Console.WriteLine("------------------------");
        }
        

        


        break;
    case 2:
        Console.WriteLine("Has seleccionado crear una persona");
        Persona persona1 = new Persona();

        Console.WriteLine("Ingrese su nombre");
        persona1.Nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su apellido");
        persona1.Apellido = Console.ReadLine();

        Console.WriteLine("Ingrese su correo");
        persona1.Correo = Console.ReadLine();

        Console.WriteLine("Ingrese su edad");
        persona1.edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su id de la ciudad");
        persona1.FKCiudad = int.Parse(Console.ReadLine());

        servicios.CreatePersona(persona1);

        break; 
    case 3:
        Console.WriteLine("Haz seleccionado actualizar persona");
        Persona persona2 = new Persona();

        Console.WriteLine("Ingrese el id a modificar");
        persona2.PKPersona = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su nombre");
        persona2.Nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su apellido");
        persona2.Apellido = Console.ReadLine();

        Console.WriteLine("Ingrese su correo");
        persona2.Correo = Console.ReadLine();

        Console.WriteLine("Ingrese su edad");
        persona2.edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su id de la ciudad");
        persona2.FKCiudad = int.Parse(Console.ReadLine());

        servicios.UpdatePersona(persona2);

        break;
    case 4:

        Console.WriteLine("Haz seleccionado eliminar persona");
        Persona persona3 = new Persona();

        Console.WriteLine("Ingrese el id a eliminar");
        persona3.PKPersona = int.Parse(Console.ReadLine());

        servicios.DeletePersona(persona3);
        Console.WriteLine("Se ha elimado con exito");

        break;
    case 5:
        Console.WriteLine("Haz seleccionado el buscar por id");
        Persona persona4 = new Persona();

        Console.WriteLine("Ingrese el id a buscar");
        persona4.PKPersona = int.Parse(Console.ReadLine());

        servicios.SearchbyID(persona4);
        

        break;

    default:

        break;
}

/*int edad = int.Parse(Console.ReadLine());
 if (edad >= 18 && edad <= 29)
{
    Console.WriteLine("Eres un adulto");
}
else if (edad >= 30 && edad <= 45)
{
    Console.WriteLine("Ya casi viejo");
}
else if (edad >= 45 && edad <= 60)
{
    Console.WriteLine("ya tas pal perro");
}
else
{
    Console.WriteLine("No vales pa nada");
}
*/

