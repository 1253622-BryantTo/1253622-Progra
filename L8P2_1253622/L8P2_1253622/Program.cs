using System;

namespace L8P2_1253622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string Nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Bienvemido " + Nombre);
            Console.WriteLine();
            Console.WriteLine("Que numero de fibonacci deasea?");
            int Numero = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (Numero <= 0)
            {
                Console.WriteLine("Error: Ese numero de Fibonacci no existe");
            }
            else
            {
                if (Numero == 0)
                {
                    Console.WriteLine("0");
                }
                else if (Numero == 2)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    int Resultado = 1;
                    int N1 = 0, N2 = 1;
                    for (int i = 3; i <= Numero; i++)
                    {
                        Resultado = N1 + N2;
                        N1 = N2;
                        N2 = Resultado;
                        Console.WriteLine(Resultado);
                    }
                }
            }
        }
    }
}
