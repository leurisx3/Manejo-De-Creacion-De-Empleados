using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_la_creacion_de_empleados
{
    public class Empleado
    {
        public string cedula { get; set; }
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string departamento { get; set; }
        public string cargo { get; set; }
        public double precio { get; set; }
        public int horas { get; set; }
        public double salarioNeto { get; set; }
        public string departamentoCodigo {get; set;}
        public double salario { get; set; }
    }
}
