using System;
using mapadeclases.entities;

namespace mapadeclases
{
    class Program
    {
        static void Main(String[] args)
        {
            Miembrodelacomunidad miembro = new Miembrodelacomunidad("Franchelys", "Batista", 18);
            miembro.presentar();

            Console.WriteLine("\n**** info estudiante****");

            Estudiante estudiant = new Estudiante("Mile", "Alonzo", 19, "Arquitectura", 0987);
            estudiant.presentar();

            Console.WriteLine("\n**** info exalumno****");

            Exalumno exalumn = new Exalumno("Rosa", "Diaz", 20, "2018", "2023");
            exalumn.presentar();

            Console.WriteLine("\n**** info empleado****");

            Empleado emplead = new Empleado("Loly", "Mendez", 28, 8988.89m, "Gerente");
            emplead.presentar();

            Console.WriteLine("\n**** info docente****");

            Docente docent = new Docente("Kimberly", "Lopez", 40, 87878m, "profesor", "qumica", 3456589);
            docent.presentar();

            Console.WriteLine("\n**** info maestro****");

            Maestro maestr = new Maestro("Jenni", "Garcia", 50, 8788m, "maestro junior", "Lengua", 9778675, 19);
            maestr.presentar();

            Console.WriteLine("\n**** info administrativo****");

            Administrativo admin = new Administrativo("Franyerson", "Bautista", 35, 87533m, "Coordinador", "Administrador", 2378557, "jefa del area");
            admin.presentar();

            Console.WriteLine("\n**** info administrador****");

            Administrador administr = new Administrador("Eaine", "Mercedez", 49, 2328m, "Directora", "Gestion", 23279429, "Directora General");
            administr.presentar();

            Console.WriteLine("\npresione una tecla para salir");
            Console.ReadKey();

        }
    }

}
