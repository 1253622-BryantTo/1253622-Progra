using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_BT1253622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Ingrese un numero mayor a 10");
            int N = int.Parse(Console.ReadLine());
            
            //Arreglo
            int[] Elementos = new int[N];

            for (int i = 0; i < Elementos.Count(); i++)
            {

               Console.WriteLine($"Ingrese numero: {i}");
               int numero = int.Parse(Console.ReadLine());
               Elementos[i] = numero;
                
            }
            Carro[] carros = new Carro[Elementos.Count()];
            string[] strings = new string[Elementos.Count()];
            double[] doubles = new double[Elementos.Count()];
            bool[] bools = new bool[Elementos.Count()];
            */
            Console.WriteLine("Igrese X");
            int X = int.Parse(Console.ReadLine());


            Console.WriteLine("Igrese Y");
            int Y = int.Parse(Console.ReadLine());

            int[,] Table = new int[X,Y];

            Table[0, 1] = 12;

            for (int x = 0; x < X;  x++)
            {
                for (int y = 0; y < Y; y++)
                {

                }
            }

        }
    }
}
