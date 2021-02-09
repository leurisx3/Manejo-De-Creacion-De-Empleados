using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_la_creacion_de_empleados
{
    class FabricaEmpleado
    {
        public static ICargo GetCargo(int cargo)
        {
            if (cargo.Equals(1))
            {
                Console.WriteLine(string.Empty);
                return new Operativo();
            }
            else if (cargo.Equals(2))
            {
                Console.WriteLine(string.Empty);
                return new Administrativo();
            }
            else if (cargo.Equals(3))
            {
                Console.WriteLine(string.Empty);
                return Gerencial.GetGerencial();
            }
            else
            {
                return null;
            }
        }
    }
}
