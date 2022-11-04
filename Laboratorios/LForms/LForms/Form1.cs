using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nombre_txt.Text == "")
            {
                Nombre_lbl.Text = "El campo esta vacio";
            }
            else
            {
                Nombre_lbl.Text = Nombre_txt.Text;
            }
        }
    }
}
