using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapadeclases.entities
{
    public class Administrador : Docente
    {
        public string Cargo { get; set; }

        public Administrador(string nombre, string apellido, int edad, decimal salario, string puesto, string especialidad, int telefono, string cargo)
            : base(nombre, apellido, edad, salario, puesto, especialidad, telefono)

        {
            Cargo = cargo;
        }
        public override void presentar()
        {
            base.presentar();
            Console.WriteLine($"este es su cargo: {Cargo}");
        }
    }

}
