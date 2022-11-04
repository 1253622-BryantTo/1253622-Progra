using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10__BT1253622.Properties
{
    internal class Carros
    {
        private string Marca = "";
        private int Modelo = 0;
        private double Precio = 0;
        private string Descripccion = "";

        public void SetMarca(string Marca)
        {
            if (Marca != "")
            {
                this.Marca = Marca;
            }
        }

        public void SetModelo(int Modelo)
        {
            this.Modelo = Modelo;
        }

        public void SetPrecio(double Precio)
        {
            this.Precio = Precio;
        }

        public void SetDescripccion(string Descripccion)
        {
            this.Descripccion = Descripccion;
        }

        public string LeerMarca()
        {
            return Marca;        
        }

        public int LeerModelo()
        {
            return Modelo;
        }

        public double LeerPrecio()
        {
            return Precio;
        }

        public string LeerDescripccion()
        {
            return Descripccion;
        }
    }
}
