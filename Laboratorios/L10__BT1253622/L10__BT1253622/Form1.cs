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

        }
    }
}
