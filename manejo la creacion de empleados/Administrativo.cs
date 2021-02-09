using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_la_creacion_de_empleados
{
    class Administrativo : Empleado, ICargo
    {
        public Administrativo()
        {
            Random random = new Random();

            cargo = "Administrativo";
            codigo = random.Next(1000, 5000);
            departamento = "SOFTWARE";
            departamentoCodigo = departamento.Substring(0, 3);

            Console.Write("Introduzca un nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Introduzca su apellido: ");
            apellido = Console.ReadLine();

            Console.Write("Introduzca su cedula: ");
            cedula = Console.ReadLine();

            Console.Write("Introduzca su email: ");
            email = Console.ReadLine();

            Console.Write("Introduzca su telefono: ");
            telefono = Console.ReadLine();

            Console.Write("Introduzca precio por hora: ");
            precio = double.Parse(Console.ReadLine());

            Console.Write("Introduzca horas trabajadas: ");
            horas = int.Parse(Console.ReadLine());
            
            salario = precio * horas;
            salarioNeto = ((salario * 0.25) + salario);

        }

        public double Cobro(double salario)
        {
            double bono = salario * 0.25;
            double resultado = bono + salario;

            return resultado;
        }
    }
}
