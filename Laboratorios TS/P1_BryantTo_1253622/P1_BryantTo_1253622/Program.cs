using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_BryantTo_1253622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Sesion = true;
            double Ingreso = 0;
            bool Continuar_ = true;
            double Egreso = 0;
            bool _Continuar = true;
            while (Sesion == true)
            {
                Console.WriteLine("Binvenido");
                Console.WriteLine();
                Console.WriteLine("Menu");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Ingresos");
                Console.WriteLine("2. Egreso");
                Console.WriteLine("3. Resultado");
                Console.WriteLine("0. Salir");
                int Opccion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (Opccion)
                {
                    case 1:
                        Ingresos();                   
                        break;
                    case 2:
                        Egresos();
                        break;
                    case 3:
                        Respuestas();
                        break;
                }   
            }

            void Ingresos()
            {

                do
                {
                    Console.WriteLine("Ingese sus Ingresos");
                    Ingreso = Ingreso + double.Parse(Console.ReadLine());
                    Console.WriteLine("Desea continuar 1) Si o 2) No....");
                    int Respuesta = int.Parse(Console.ReadLine());
                    if (Respuesta == 1)
                    {
                        Continuar_ = true;
                    }
                    else if (Respuesta == 2)
                    {
                        Continuar_ = false;
                    }
                } while (Continuar_ == true);
            }

            void Egresos()
            {
                do
                {
                    Console.WriteLine("Ingese sus Egresos");
                    Egreso = Egreso + double.Parse(Console.ReadLine());
                    Console.WriteLine("Desea continuar Si o No....");
                    string Respuesta = Console.ReadLine();
                    if (Respuesta == "Si")
                    {
                        _Continuar = true;
                    }
                    else if (Respuesta == "No")
                    {
                        _Continuar = false;
                    }
                } while (_Continuar == true);
            }
            void Respuestas()
            {
                double Resultado = Ingreso - Egreso;
                if (Resultado == 0)
                {
                    Console.WriteLine("Tablas");
                }
                else if (Resultado > 0)
                {
                    Console.WriteLine("Consejos de Invercion");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("1. No dejarse llevar por las emociones\n2. No sobreinvertir ni sobrenegociar\n3. Descubrir nuevas opciones y alternativas\n4. Tener claros los objetivos");
                }
                else if (Resultado < 0)
                {
                    Console.WriteLine("Consejos Mejorar tu Presupuesto");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("1. Crea tu presupuesto el día 1 de cada mes\n2. Practica el presupuesto a cero\n3. Establezca claramente tus necesidades\n4. Ten a mano todos tus recibos y facturas");
                }
            }

        }
    }
}
