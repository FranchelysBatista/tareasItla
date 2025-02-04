using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapadeclases.entities
{
    public class Maestro : Docente
    {
        public int Yeardeeduca { get; set; }

        public Maestro(string nombre, string apellido, int edad, decimal salario, string puesto, string especialidad, int telefono, int yeardeeduca)
            : base(nombre, apellido, edad, salario, puesto, especialidad, telefono)

        {

            Yeardeeduca = yeardeeduca;
        }

        public override void presentar()
        {
            base.presentar();
            Console.WriteLine($"esto es el años ejercido: {Yeardeeduca}");
        }


    }
}
