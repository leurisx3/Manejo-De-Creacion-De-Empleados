using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_la_creacion_de_empleados
{
    class Gerencial : Empleado, ICargo
    {
        //Instancia random

        Random random = new Random();

        //Logica del salario del gerente
        public double Cobro(double salario)
        {
            double bono = salario * 0.5;
            double resultado = bono + salario;

            return resultado;
        }


        //Singleton

        private static Gerencial unicoGerente;

        private Gerencial(string nombre, string apellido, string cedula, string email, string telefono, double precio, int horas)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.email = email;
            this.telefono = telefono;
            this.precio = precio;
            this.horas = horas;

            cargo = "Gerencial";
            codigo = random.Next(1000, 5000);
            departamento = "SOFTWARE";
            departamentoCodigo = departamento.Substring(0, 3);

            salario = precio * horas;
            salarioNeto = ((salario * 0.5) + salario);
        }

        public static Gerencial GetGerencial()
        {

            Console.Write("Introduzca el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Introduzca el apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Introduzca su cedula: ");
            string cedula = Console.ReadLine();

            Console.Write("Introduzca su email: ");
            string email = Console.ReadLine();

            Console.Write("Introduzca su telefono: ");
            string telefono = Console.ReadLine();

            Console.Write("Introduzca precio por hora: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Introduzca horas trabajadas: ");
            int horas = int.Parse(Console.ReadLine());

            if (unicoGerente == null)
            {
                unicoGerente = new Gerencial(nombre, apellido, cedula, email, telefono, precio, horas);
                return unicoGerente;
            }
                return unicoGerente;
        }
    }
}
