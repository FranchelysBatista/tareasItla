using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapadeclases.entities
{
    public class Empleado : Miembrodelacomunidad
    {
        public decimal Salario { get; set; }
        public string Puesto { get; set; }

        public Empleado(string nombre, string apellido, int edad, decimal salario, string puesto)
            : base(nombre, apellido, edad)
        {
            Salario = salario;
            Puesto = puesto;

        }

        public override void presentar()
        {
            base.presentar();
            Console.WriteLine($"este es su salario: {Salario}");
            Console.WriteLine($"este es su puesto: {Puesto}");
        }
    }
}
