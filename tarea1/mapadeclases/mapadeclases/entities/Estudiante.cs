using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapadeclases.entities
{
    public class Estudiante : Miembrodelacomunidad
    {
        public string Carrera { get; set; }
        public int Matricula { get; set; }

        public Estudiante(string nombre, string apellido, int edad, string carrera, int matricula)
            : base(nombre, apellido, edad)
        {
            Carrera = carrera;
            Matricula = matricula;

        }
        public override void presentar()
        {
            base.presentar();
            Console.WriteLine($"este es su carrera: {Carrera}");
            Console.WriteLine($"este es su matricula: {Matricula}");
        }
    }

}