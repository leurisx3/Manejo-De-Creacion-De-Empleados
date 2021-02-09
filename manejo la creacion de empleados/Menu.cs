using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_la_creacion_de_empleados
{
    class Menu
    {
        static List<Empleado> empleados = new List<Empleado>();

        public static void MenuEmpleados()
        {

            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("MENU MANEJO DE EMPLEADOS\n");
                Console.WriteLine("1- Crear empleado\n" +
                                  "2- Ver empleado\n" +
                                  "3- Cobrar\n" +
                                  "4- Recibo de pago\n" +
                                  "5- Salir\n");
                Console.Write("Introduzca una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                Console.WriteLine(string.Empty);

                int cargo;

                switch (opcion)
                {
                    case 1:

                        cargo = TipoCargo();
                        empleados.Add((Empleado)FabricaEmpleado.GetCargo(cargo));

                        if (cargo.Equals(0))
                        {
                            MenuEmpleados();
                        }

                        break;

                    case 2:

                        foreach (Empleado empleado in empleados)
                        {
                            Console.WriteLine("   --Empleados-- ");
                            Console.WriteLine($" Codigo: {empleado.departamentoCodigo}{empleado.codigo}\n Cargo: {empleado.cargo}\n Nombre completo: {empleado.nombre} {empleado.apellido}\n " +
                                              $"Cedula: {empleado.cedula}\n Email: {empleado.email}\n Telefono: {empleado.telefono}\n");  
                        }

                        Console.ReadKey();

                        break;

                    case 3:
                        foreach (Empleado empleado in empleados)
                        {
                            Console.WriteLine("   --Cobrar-- ");
                            Console.WriteLine($" Codigo: {empleado.departamentoCodigo}{empleado.codigo}\n Cargo: {empleado.cargo}\n" +
                                              $" Nombre completo: {empleado.nombre} {empleado.apellido}\n" +
                                              $" Su salario (bono aun no aplicado) es: {empleado.salario}\n");
                        }

                        Console.ReadKey();

                        break;

                    case 4:
                        foreach (Empleado empleado in empleados)
                        {
                            Console.WriteLine("   --Recibo de pago-- ");
                            Console.WriteLine($" Codigo: {empleado.departamentoCodigo}{empleado.codigo}\n Cargo: {empleado.cargo}\n" +
                                              $" Nombre completo: {empleado.nombre} {empleado.apellido}\n Precio por hora: {empleado.precio}\n" +
                                              $" Horas trabajadas: {empleado.horas}\n Su salario neto (bono aplicado) es: {empleado.salarioNeto}\n");
                        }

                        Console.ReadKey();

                        break;

                    case 5:
                        Console.WriteLine("Apagando el programa....");
                        Console.ReadKey();

                        break;

                }

            } while (opcion != 5);
        }


        public static int TipoCargo()
        {
            Console.WriteLine("Presione (0) para regresar al menu principal\n");

            Console.Write("1- Operativo\n" +
                          "2- Administrativo\n" +
                          "3- Gerencial\n" +
                          "\nQue cargo tiene el empleado? ");
            int cargo = int.Parse(Console.ReadLine());

            return cargo;
        }
    }
}
