using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_1253622_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Ejercicio #2");
            Console.WriteLine();
            Console.WriteLine("Ingres un numero A");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingres un numero B");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingres un numero C");
            C = int.Parse(Console.ReadLine());

            if (A > B)
            {
                if (A > C)
                {
                    Console.WriteLine("A es mayo a B y C");
                }
                else
                {
                    if (A == C)
                    {
                        Console.WriteLine("A y C son mayores a B");
                    }
                    else
                    {
                        Console.WriteLine("C es el mayor");
                    }
                }
                
            }
            else
            {
                if (A == B)
                {
                    if (A > C)
                    {
                        Console.WriteLine("A y B son iguales y mayores a C");
                    }
                    else
                    {
                        if (A == C)
                        {
                            Console.WriteLine("A y C y B son iguales");
                        }
                        else
                        {
                            Console.WriteLine("A y B son iguales y diferente a C");
                        }
                    }
                }
                else
                {
                    if (B > C)
                    {
                        Console.WriteLine("A y B son iguales y mayores a C");
                    }
                    else
                    {
                        if (B == C)
                        {
                            Console.WriteLine("B es igual a C y diferente a A");
                        }
                        else 
                        {
                            Console.WriteLine("B es direfente a C");
                        }                       
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
