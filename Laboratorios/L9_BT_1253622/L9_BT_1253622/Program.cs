using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_BT_1253622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo Obj_Circulo = new Circulo(100);
            double Area = Obj_Circulo.Obtener_Area();
            double Perimetro = Obj_Circulo.Obtener_Perimetro();
            double Volumen = Obj_Circulo.Obtener_Volumen();

            Obj_Circulo.Calcular_Geometria(Perimetro, Area, Volumen);

            Console.ReadKey();
        }
    }
}
