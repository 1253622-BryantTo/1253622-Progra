using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9BT_1253622
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Motocicleta Obj_Motocicleta = new Motocicleta();

            Obj_Motocicleta.Definir_Precio(7000);
            Obj_Motocicleta.Definir_IVA(0.5);

            Console.WriteLine("Datos:");
            Console.WriteLine(Obj_Motocicleta.Mostrar_Datos());
            Console.WriteLine("Precio sin IVA:" + Obj_Motocicleta.Precio_SinIVA());
            Console.WriteLine("Iva: " + Obj_Motocicleta.Calcular_Iva());
            Console.WriteLine("Precio final: " + Obj_Motocicleta.Precion_ConIVA());

        }
    }
}
