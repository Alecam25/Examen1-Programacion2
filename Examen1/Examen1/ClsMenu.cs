using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class ClsMenu
    {
        static int opcion = 0;

        public static void Desplegar()
        {
            Console.Clear();
            do
            {

                Console.WriteLine("1-Inicializar Arreglos");
                Console.WriteLine("2-Agregar Empleados");
                Console.WriteLine("3-Consultar Empleados ");
                Console.WriteLine("4-Modificar Empleados ");
                Console.WriteLine("5-Borrar Empleados  ");
                Console.WriteLine("6-Reportes");
                Console.WriteLine("7-Salir");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:ClsEmpleado.inicializar();
                      
                        break;
                    case 2:ClsEmpleado.AgregarEmpleados();
                    
                        break;
                    case 3:ClsEmpleado.Consultarempleados(ClsEmpleado.solicitarcedula()) ;
                      
                        break;
                    case 4:ClsEmpleado.ModificarEmpeleado(ClsEmpleado.solicitarcedula());
                      
                        break;
                    case 5:ClsEmpleado.BorraEmpleado(ClsEmpleado.solicitarcedula());
                        break;

                    case 6:
                        Console.Clear();
                        Submenu();
                        break;

                    case 7:
                        break;
                    default:
                        break;

                }





            } while (opcion != 7);




        }


        public static void Submenu()
        {

            do
            {

                Console.WriteLine("1-Consultar empleados ");
                Console.WriteLine("2-Lista de todos los empleados ");
                Console.WriteLine("3-Promedio de los salarios ");
                Console.WriteLine("4-Salario mas alto y mas bajo de los empleados");
                Console.WriteLine("5-Regresar");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:ClsEmpleado.Consultarempleados2(ClsEmpleado.solicitarcedula());
                       
                        break;
                    case 2:ClsEmpleado.ListaEmpleados();
             
                        break;
                    case 3:ClsEmpleado.PromedioSlarios();
                         break;
                    case 4:ClsEmpleado.MayorMenorSalarios();
                        break;
            
                    case 5:

                        break;

                    default:
                        break;

                }





            } while (opcion != 5);
        }
    }
}
