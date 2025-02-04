using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapadeclases.entities
{
    public class Docente : Empleado
    {
        public string Especialidad { get; set; }

        public int Telefono { get; set; }

        public Docente(string nombre, string apellido, int edad, decimal salario, string puesto, string especialidad, int telefono)
            : base(nombre, apellido, edad, salario, puesto)

        {

            Especialidad = especialidad;
            Telefono = telefono;
        }

        public override void presentar()
        {
            base.presentar();
            Console.WriteLine($"su especialidad es: {Especialidad}");
            Console.WriteLine($"su telefono es: {Telefono}");
        }
    }

}
