using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class ClsEmpleado
    {
        static int cantidad = 2;

        static public string[] Cedula = new string[cantidad];

        static string[] nombre = new string[cantidad];

        static string[] Telefono = new string[cantidad];
        
        static string[] Direccion = new string[cantidad];

        static public int[] Salario = new int[cantidad];

   

        static public void inicializar()
        {

            Cedula = Enumerable.Repeat("", cantidad).ToArray();
            nombre = Enumerable.Repeat("", cantidad).ToArray();
            Telefono = Enumerable.Repeat("", cantidad).ToArray();
            Direccion = Enumerable.Repeat("", cantidad).ToArray();
            Salario = Enumerable.Repeat(1, cantidad).ToArray();

           
            Console.WriteLine("Programa inicializado"); ;
        }

        static public void AgregarEmpleados()
        {
            Console.Clear();
            int cont = 1;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digte la cedula del empleado {0}:  ", cont);
                Cedula[i] = Console.ReadLine();
                Console.WriteLine("Digte el nombre del empleado {0}:  ", cont);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Digte el telefono del empleado {0}:  ", cont);
                Telefono[i] = Console.ReadLine();
                Console.WriteLine("Digte la direccion del empleado {0}:  ", cont);
                Direccion[i] = Console.ReadLine();
                Console.WriteLine("Digte el salario del empleado {0}:  ", cont);
                int.TryParse(Console.ReadLine(), out Salario[i]);
                cont++;
                Console.Clear();

            }



        }

        public static string solicitarcedula()
        {
            Console.WriteLine("Digite la cedula ");
            string ced = Console.ReadLine();
            return ced;

        }


        static public void Consultarempleados(string ced)
        {
            Console.Clear();
            bool encontrado = false;
            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(Cedula[i]))
                {
                    Console.WriteLine($"Nombre: {nombre[i]} xxxx Telefono: {Telefono[i]} xxxx Direccion: {Direccion[i]} xxxx Salario: {Salario[i]}");
                    break;
                    encontrado = true;
                    break;

                }
                if (!encontrado)
                {
                    Console.WriteLine("Empleado no existente");
                }

                Console.Clear();
            }
        }

        public static void ModificarEmpeleado(String ced)
        {
            Console.Clear();
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(Cedula[i]))
                {
                    Console.WriteLine("Digte el nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Digte la direccion del empleado: ");
                    Direccion[i] = Console.ReadLine();
                    Console.WriteLine("Digte el Telefono del empleado: ");
                    Telefono[i] = Console.ReadLine();
                    Console.WriteLine("Digte el salario del empleado: ");
                    int.TryParse(Console.ReadLine(), out Salario[i]);
                    encontrado = true;
                    break;

                }
                if (!encontrado)
                {
                    Console.WriteLine("Empleado no existente");


                }
                Console.Clear();



            }
        }

        public static void BorraEmpleado (String ced) 
        {
            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(Cedula[i]))
                {

                    Console.WriteLine("Empleado Eliminado");
                    Cedula[i] = "";
                    nombre[i] = "";
                    Telefono[i] = "";
                    Direccion[i] = "";
                    Salario[i] = 0;
                    encontrado = true;
                    break;

                }
                if (!encontrado)
                {
                    Console.WriteLine("Empleado no existente");


                }
                






            }
        }
        static public void Consultarempleados2(string ced)
        {
            Console.Clear();
            bool encontrado = false;
            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(Cedula[i]))
                {
                    Console.WriteLine($"Nombre: {nombre[i]} xxxx Telefono: {Telefono[i]} xxxx Direccion: {Direccion[i]} xxxx Salario: {Salario[i]}");
                    break;
                    encontrado = true;
                    break;

                }
                if (!encontrado)
                {
                    Console.WriteLine("Empleado no existente");
                }
                Console.Clear();

            }
        }

        static public void ListaEmpleados()
        {
            Console.Clear();
            Console.WriteLine("Lista Empleados");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"{nombre[i]}");

             
            }
  
        }


        static public void PromedioSlarios()
        {
            Console.Clear();
            int suma = 0;

            foreach(int  salrios in Salario)
            {
                suma += salrios;


            }

            float promedio = (float)suma / Salario.Length;
            Console.WriteLine($"El promedio de los salarios es de: {promedio}%");
           
        }


        static public void MayorMenorSalarios()
        {
            Console.Clear();
            int maximo = Salario.Max();
            int minimo = Salario.Min();
            foreach (int salrios in Salario)
            {
                if (salrios > maximo)
                {
                    maximo = salrios;
                }else if (salrios < minimo)
                {
                    minimo = salrios;
                }
            }
            Console.WriteLine($"El salario mayor es de:  {maximo}");
            Console.WriteLine($"El salario menor es de:  {minimo}");
          
        }


  



    }
}


