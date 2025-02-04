using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapadeclases.entities
{
    public class Administrativo : Docente
    {
        public string Posicion { get; set; }

        public Administrativo(string nombre, string apellido, int edad, decimal salario, string puesto, string especialidad, int telefono, string posicion)
            : base(nombre, apellido, edad, salario, puesto, especialidad, telefono)
        {
            Posicion = posicion;

        }

        public override void presentar()
        {
            base.presentar();
            Console.WriteLine($"este es su posicion: {Posicion}");
        }
    }

}
