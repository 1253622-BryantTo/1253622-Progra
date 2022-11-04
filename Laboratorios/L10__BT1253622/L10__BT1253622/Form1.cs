using L10__BT1253622.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace L10__BT1253622
{
    public partial class Form1 : Form
    {
        Carros carros = new Carros();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BtnCargarDatos_Click(object sender, EventArgs e)
        {

            string Marca = InputMarca.Text;
            int Modelo = (int)ImputModelo.Value;
            double Precio = (double)ImputPrecio.Value;
            string Descripccion = ImputDescripccion.Text;

            carros.SetMarca(Marca);
            carros.SetPrecio(Precio);
            carros.SetDescripccion(Descripccion);
            carros.SetModelo(Modelo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputMarcar.Text = carros.LeerMarca();
            OutputDescripccion.Text = carros.LeerDescripccion();
            OutputPrecio.Text = carros.LeerPrecio().ToString();
            OutputModelo.Text = carros.LeerModelo().ToString();
            string Mensage = "Se han cargado exitosamente sus datos";
            string Datos = "Datos";
            MessageBoxButtons CargarDatos = MessageBoxButtons.OK;
            MessageBox.Show(Mensage, Datos, CargarDatos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Iva = (double)ImputIva.Value;
            carros.SetIva(Iva);
            OutputPrecioFinal.Text = "Q" + carros.LeerPrecioFinal().ToString();
            string IVA = OutputPrecioFinal.Text;
            string Mensage = "Su precio con Iva incluido es de: ";
            MessageBoxButtons boxButtons = MessageBoxButtons.OK;
            MessageBox.Show(IVA, Mensage, boxButtons);
        }
    }
}
