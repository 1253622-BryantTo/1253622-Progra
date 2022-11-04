using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9BT_1253622
{
    internal class Motocicleta
    {

        private int modelo = 2019;
        private double precio = 1000;
        private string Marca = "";
        private double IVA = 0.12;

        public string Mostrar_Datos()
        {
            string Datos = "Modelo:" + modelo + "\n" + "Precio: Q" + precio + "\n" + "Marca: " + Marca;
            return Datos;
        }

        public void Definir_Precio(double _precio)
        {
            precio = _precio; 
        }

        public void Definir_IVA(double _IVA)
        {
            if (_IVA > 0 && _IVA < 1)
            {
                IVA = _IVA;
            }
            
        }

        public double Precio_SinIVA()
        {
            return precio;
        }

        public double Precion_ConIVA()
        {
            return precio + Calcular_Iva();
        }

        public double Calcular_Iva()
        {
            return precio * IVA;
        }



    }
}
