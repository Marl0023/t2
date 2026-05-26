using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBBP ArbolEmpleados = new ArbolBBP();
            ArbolEmpleados.Agregar(3689,"Marlo",1);
            ArbolEmpleados.Agregar(2378, "jua", 7);
            ArbolEmpleados.Agregar(4975, "d2", 9);
            ArbolEmpleados.Agregar(8162, "dagb",3);
            ArbolEmpleados.Agregar(4763, "vvvv", 4);
            ArbolEmpleados.Agregar(5915, "aaaa", 11);
            ArbolEmpleados.Agregar(1584, "mmm", 10);
            ArbolEmpleados.Agregar(5861, "dds", 6);
            int op;
            do
            {
                Console.WriteLine("\nLista de Opciones: ");
                
                
                Console.WriteLine("1- Agregar");
                Console.WriteLine("2- Listar1");
                Console.WriteLine("3- Listar2");
                Console.WriteLine("4- Mayores a cierta antiguedad");
                Console.WriteLine("5- Penultimo segun el codigo");
                Console.WriteLine("===================================================");
                Console.WriteLine("Ingrese una opciion: ");
                op = int.Parse(Console.ReadLine());
                switch (op) {
                    case 1:
                        
                        Console.WriteLine("Ingrese nombre: ");
                        string nom = Console.ReadLine();
                        Console.WriteLine("Ingrese codigo: ");
                        int cod = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese nombre: ");
                        int antiguedad = int.Parse(Console.ReadLine());
                        ArbolEmpleados.Agregar(cod, nom, antiguedad);
                        break;
                    case 2:
                        ArbolEmpleados.MuestraInCodigo();
                        break;
                    case 3:
                        ArbolEmpleados.MuestraPosAntiguedad();
                        break;
                    case 4:
                        Console.WriteLine("Ingrese un valor para buscar por antiguedad empleados mayores a: ");
                        int anti = int.Parse(Console.ReadLine());
                        ArbolEmpleados.MayoresA(anti);
                        break;
                    case 5:
                        Console.WriteLine("Penultimo empleado: ");
                        ArbolEmpleados.Penultimo();
                        break;
                    case 9:
                        Console.WriteLine("Saliendo");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion correcta");
                        break;
                }



            }
            while (op!=9);
            
        }
    }
}
