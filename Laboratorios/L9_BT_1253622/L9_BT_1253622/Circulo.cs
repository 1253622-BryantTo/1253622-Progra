using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_BT_1253622
{
    internal class Circulo
    {
        //Atributo
        private double Radio;

        //Metodo Constructor
        //Opccioal
        public Circulo(double Radio)
        {
            this.Radio = Radio;
        }

        public double Obtener_Perimetro()
        {
            return 2 * Math.PI * Radio;
        }
        
        public double Obtener_Area()
        {
            return Math.PI * Math.Pow(Radio,2);
        }

        public double Obtener_Volumen()
        {
            return 4/3 * Math.PI * Math.Pow(Radio,2);
        }

        public void Calcular_Geometria(double _Perimetro, double _Area, double _Volumen)
        {
            Console.WriteLine("Perimetro: " + _Perimetro);
            Console.WriteLine("Area: " + _Area);
            Console.WriteLine("Volumen:" + _Volumen);
        }
    }
}
