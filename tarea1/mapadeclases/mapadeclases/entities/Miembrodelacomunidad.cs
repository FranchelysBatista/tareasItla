using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapadeclases.entities
{
    public class Miembrodelacomunidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public Miembrodelacomunidad(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public virtual void presentar()
        {
            Console.WriteLine($"El nombre es: {Nombre} ");
            Console.WriteLine($"El apellido es: {Apellido} ");
            Console.WriteLine($"La edad es: {Edad} ");
        }
    }
}
