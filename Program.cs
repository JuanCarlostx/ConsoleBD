// See https://aka.ms/new-console-template for more information
using Ejemplodeifelse2.Entities;
using Ejemplodeifelse2.Funciones;

PersonaServicios servicios = new PersonaServicios();

Console.WriteLine("Hello, World!");
Console.WriteLine( "Ingrese su edad");

Console.WriteLine("Ingresa una de las siguientes opciones");
Console.WriteLine( "1. Listar persona");
Console.WriteLine( "2. Crear persona");

int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Has seleccionado ver la lista");
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

