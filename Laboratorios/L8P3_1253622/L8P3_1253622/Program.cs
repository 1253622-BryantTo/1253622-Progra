using System;

namespace L8P3_1253622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio While
            Console.WriteLine("Ingrese un numero ");
            int Numero = int.Parse(Console.ReadLine());
            Console.Clear();
            while (Numero > 18)
            {
                Console.WriteLine("Aun estas a salvo");
                Console.WriteLine("Ingrese otro numero");

                Numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Veamos...");
                Console.Clear();
            }  
            Console.WriteLine("Ya no estas a salvo");
            Console.Clear();

            //Ejercicio Do While
            do
            {
                Console.WriteLine("Este es do while");

            } while (Numero > 18);
        }
    }
}
