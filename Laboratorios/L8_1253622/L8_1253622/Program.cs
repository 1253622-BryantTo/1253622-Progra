using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_1253622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio #1");
            Console.WriteLine();
            Console.WriteLine("Ingrese el numero del mes");
            int mes = int.Parse(Console.ReadLine());

            if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Error: El numero ingresado debe de estar en el rango de 1 a 12");
            }
            else
            {
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Enereo");
                        break;
                    case 2:
                        Console.WriteLine("Febrero");
                        break;
                    case 3:
                        Console.WriteLine("Marzo");
                        break;
                    case 4:
                        Console.WriteLine("Abril");
                        break;
                    case 5:
                        Console.WriteLine("Mayo");
                        break;
                    case 6:
                        Console.WriteLine("Junio");
                        break;
                    case 7:
                        Console.WriteLine("Julio");
                        break;
                    case 8:
                        Console.WriteLine("Agosto");
                        break;
                    case 9:
                        Console.WriteLine("Septiembre");
                        break;
                    case 10:
                        Console.WriteLine("Octubre");
                        break;
                    case 11:
                        Console.WriteLine("Noviembre");
                        break;
                    case 12:
                        Console.WriteLine("Diciembre");
                        break;
                }                
            }
            Console.ReadKey();
        }
    }
}
