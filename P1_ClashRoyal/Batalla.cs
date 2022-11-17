using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_ClashRoyal
{
    public partial class Batalla : Form
    {
        string MazoJ1 = string.Empty;
        string MazoJ2 = string.Empty;
        int CoronasJ1 = 0, CoronasJ2 = 0;

        public void Jugadores(string NombreJ1, string NombreJ2)
        {
            txtNombreJ1.Text = NombreJ1;
            txtNombreJ2.Text = NombreJ2;
        }
        public Batalla()
        {
            InitializeComponent();
        }
        public void JugadoresMazo( string MazoJ1, string MazoJ2)
        { 
            txtMazoJ1.Text = MazoJ1;
            txtMazoJ2.Text = MazoJ2;
            if (MazoJ1 == "Phoenix Mortar bait" && MazoJ2 == "PEKKA DartGob bait")
            {
                picMazoJ1.Image = Image.FromFile(@"D:\Usuario\Documents\GitHub\1253622-Progra\P1_ClashRoyal\P1_ClashRoyal\Cartas\Phoenix Mortar bait.PNG");
                picMazoJ2.Image = Image.FromFile(@"D:\Usuario\Documents\GitHub\1253622-Progra\P1_ClashRoyal\P1_ClashRoyal\Cartas\PEKKA DartGob bait.PNG");
            }
            else if (MazoJ1 == "RG Mother Witch Fisherman" && MazoJ2 == "Sudden Death Hog bait")
            {
                picMazoJ1.Image = Image.FromFile(@"D:\Usuario\Documents\GitHub\1253622-Progra\P1_ClashRoyal\P1_ClashRoyal\Cartas\RG Mother Witch Fisherman.PNG");
                picMazoJ2.Image = Image.FromFile(@"D:\Usuario\Documents\GitHub\1253622-Progra\P1_ClashRoyal\P1_ClashRoyal\Cartas\Sudden Death Hog bait.PNG");
            }
            else if (MazoJ1 == "Phoenix Mortar bait" && MazoJ2 == "Sudden Death Hog bait")
            {
                picMazoJ1.Image = Image.FromFile(@"D:\Usuario\Documents\GitHub\1253622-Progra\P1_ClashRoyal\P1_ClashRoyal\Cartas\Phoenix Mortar bait.PNG");
                picMazoJ2.Image = Image.FromFile(@"D:\Usuario\Documents\GitHub\1253622-Progra\P1_ClashRoyal\P1_ClashRoyal\Cartas\Sudden Death Hog bait.PNG");
            }
            else if (MazoJ1 == "RG Mother Witch Fisherman" && MazoJ2 == "PEKKA DartGob bait")
            {
                picMazoJ1.Image = Image.FromFile(@"D:\Usuario\Documents\GitHub\1253622-Progra\P1_ClashRoyal\P1_ClashRoyal\Cartas\RG Mother Witch Fisherman.PNG");
                picMazoJ2.Image = Image.FromFile(@"D:\Usuario\Documents\GitHub\1253622-Progra\P1_ClashRoyal\P1_ClashRoyal\Cartas\PEKKA DartGob bait.PNG");
            }
        }
        
        private void Batalla_Load(object sender, EventArgs e)
        {
            txtNombreJ1.BackColor = Color.Transparent;
            txtNombreJ2.BackColor = Color.Transparent;
            txtContadorJ1.BackColor = Color.Transparent;
            txtContadorJ2.BackColor = Color.Transparent;
            txtMazoJ1.BackColor = Color.Transparent;
            txtMazoJ2.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MazoJ1 = txtMazoJ1.Text;
            string MazoJ2 = txtMazoJ2.Text;
            if (CoronasJ1 > CoronasJ2)
            {
                MessageBox.Show($"EL mejo mazo es el {MazoJ1}", "Resultados", MessageBoxButtons.OK);
            }
            else if (CoronasJ1 < CoronasJ2)
            {
                MessageBox.Show($"El mejor mazo es el {MazoJ2}", "Resultados", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Muerte Súbita", "Resultados", MessageBoxButtons.OK);
                this.Hide();
                Muerte_Subita muerte_Subita = new Muerte_Subita();
                muerte_Subita.Show();
                muerte_Subita.Contadores(CoronasJ1, CoronasJ2);
                muerte_Subita.JugadoresDesempate(txtNombreJ1.Text,txtNombreJ2.Text);
                muerte_Subita.JugadoresMazoDesempate(MazoJ1,MazoJ2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClashRoyal clashRoyal = new ClashRoyal();
            clashRoyal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Inicio = new Form1();
            Inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string J1 = txtMazoJ1.Text;
            string J2 = txtMazoJ2.Text;
            Mazo Batalla = new Mazo();
            if (J1 == "Phoenix Mortar bait" && J2 == "PEKKA DartGob bait")
            {
                if (Batalla.GetDañoM1J2() < Batalla.GetVidaM1J1() && Batalla.GetDañoM1J1() > Batalla.GetVidaM1J2())
                {
                    CoronasJ1 += 3;
                    if (Batalla.GetDañoM1J2() < Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM1J2() < Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM1J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;                                  
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                }
                else if (Batalla.GetDañoM1J1() < Batalla.GetVidaM1J2() && Batalla.GetDañoM1J2() > Batalla.GetVidaM1J1())
                {
                    CoronasJ2 += 3;
                    if (Batalla.GetDañoM1J2() < Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM1J2() < Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM1J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                    else if (Batalla.GetDañoM1J2() > Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM1J2() > Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ2 += 3;
                        if (Batalla.GetVidaM1J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetVidaM1J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetVidaM1J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (Batalla.GetDañoM1J1() > Batalla.GetVidaM1J2() && Batalla.GetDañoM1J2() > Batalla.GetVidaM1J1())
                {
                    CoronasJ1 += 1;
                    CoronasJ2 += 1;
                    if (Batalla.GetDañoM1J2() < Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM1J2() < Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM1J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                    else if (Batalla.GetDañoM1J2() > Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM1J2() > Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ2 += 3;
                        if (Batalla.GetVidaM1J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetVidaM1J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetVidaM1J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (Batalla.GetDañoM1J1() < Batalla.GetVidaM1J2() && Batalla.GetDañoM1J2() < Batalla.GetVidaM1J1())
                {
                    CoronasJ1 += 1;
                    CoronasJ2 += 1;
                    if (Batalla.GetDañoM1J2() < Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM1J2() < Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM1J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) >(Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                    else if (Batalla.GetDañoM1J2() > Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM1J2() > Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ2 += 3;
                        if (Batalla.GetVidaM1J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetVidaM1J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetVidaM1J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                    }

                }
            }
            else if (J1 == "RG Mother Witch Fisherman" && J2 == "Sudden Death Hog bait")
            {
                if (Batalla.GetDañoM2J2() < Batalla.GetVidaM2J1() && Batalla.GetDañoM2J1() > Batalla.GetVidaM2J2())
                {
                    CoronasJ1 += 3;
                    if (Batalla.GetDañoM2J2() < Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM2J2() < Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM2J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                }
                else if (Batalla.GetDañoM2J1() < Batalla.GetVidaM2J2() && Batalla.GetDañoM2J2() > Batalla.GetVidaM2J1())
                {
                    CoronasJ2 += 3;
                    if (Batalla.GetDañoM2J2() < Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM2J2() < Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM2J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                    else if (Batalla.GetDañoM2J2() > Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM2J2() > Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ2 += 3;
                        if (Batalla.GetVidaM2J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetVidaM2J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetVidaM2J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (Batalla.GetDañoM2J1() > Batalla.GetVidaM2J2() && Batalla.GetDañoM2J2() > Batalla.GetVidaM2J1())
                {
                    CoronasJ1 += 1;
                    CoronasJ2 += 1;
                    if (Batalla.GetDañoM2J2() < Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM2J2() < Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM2J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                    else if (Batalla.GetDañoM2J2() > Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM2J2() > Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ2 += 3;
                        if (Batalla.GetVidaM2J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetVidaM2J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetVidaM2J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (Batalla.GetDañoM2J1() < Batalla.GetVidaM2J2() && Batalla.GetDañoM2J2() < Batalla.GetVidaM2J1())
                {
                    CoronasJ1 += 1;
                    CoronasJ2 += 1;
                    if (Batalla.GetDañoM2J2() < Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM2J2() < Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM2J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                    else if (Batalla.GetDañoM2J2() > Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM2J2() > Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ2 += 3;
                        if (Batalla.GetVidaM2J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetVidaM2J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetVidaM2J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                    }

                }
            }
            else if (J1 == "Phoenix Mortar bait" && J2 == "Sudden Death Hog bait")
            {
                if (Batalla.GetDañoM2J2() < Batalla.GetVidaM1J1() && Batalla.GetDañoM1J1() > Batalla.GetVidaM2J2())
                {
                    CoronasJ1 += 3;
                    if (Batalla.GetDañoM2J2() < Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM2J2() < Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM1J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                }
                else if (Batalla.GetDañoM1J1() < Batalla.GetVidaM2J2() && Batalla.GetDañoM2J2() > Batalla.GetVidaM1J1())
                {
                    CoronasJ2 += 3;
                    if (Batalla.GetDañoM2J2() < Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM2J2() < Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM1J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                    else if (Batalla.GetDañoM2J2() > Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM2J2() > Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ2 += 3;
                        if (Batalla.GetVidaM1J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetVidaM1J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetVidaM1J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (Batalla.GetDañoM1J1() > Batalla.GetVidaM2J2() && Batalla.GetDañoM2J2() > Batalla.GetVidaM1J1())
                {
                    CoronasJ1 += 1;
                    CoronasJ2 += 1;
                    if (Batalla.GetDañoM2J2() < Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM2J2() < Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM1J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                    else if (Batalla.GetDañoM2J2() > Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM2J2() > Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ2 += 3;
                        if (Batalla.GetVidaM1J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetVidaM1J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetVidaM1J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (Batalla.GetDañoM1J1() < Batalla.GetVidaM2J2() && Batalla.GetDañoM2J2() < Batalla.GetVidaM1J1())
                {
                    CoronasJ1 += 1;
                    CoronasJ2 += 1;
                    if (Batalla.GetDañoM2J2() < Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM2J2() < Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM1J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                    else if (Batalla.GetDañoM2J2() > Batalla.GetDañoM1J1() && Batalla.GetVelocidadAtaqueM2J2() > Batalla.GetVelocidadAtaqueM1J1())
                    {
                        CoronasJ2 += 3;
                        if (Batalla.GetVidaM1J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetVidaM1J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                        else if (Batalla.GetVidaM1J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetVidaM1J1() < Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM1J1() > Batalla.GetVidaM2J2() && (Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM1J1() > Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM1J1() < Batalla.GetDañoM2J2() && (Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) > (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM1J1() + Batalla.GetDefensaM1J1() + Batalla.GetSinergiaM1J1() + Batalla.GetBalanceM1J1()) < (Batalla.GetAtaqueM2J2() + Batalla.GetDefensaM2J2() + Batalla.GetSinergiaM2J2() + Batalla.GetBalanceM2J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                    }

                }
            }
            else if (J1 == "RG Mother Witch Fisherman" && J2 == "PEKKA DartGob bait")
            {
                if (Batalla.GetDañoM1J2() < Batalla.GetVidaM2J1() && Batalla.GetDañoM2J1() > Batalla.GetVidaM1J2())
                {
                    CoronasJ1 += 3;
                    if (Batalla.GetDañoM1J2() < Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM1J2() < Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM2J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                }
                else if (Batalla.GetDañoM2J1() < Batalla.GetVidaM1J2() && Batalla.GetDañoM1J2() > Batalla.GetVidaM2J1())
                {
                    CoronasJ2 += 3;
                    if (Batalla.GetDañoM1J2() < Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM1J2() < Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM2J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                    else if (Batalla.GetDañoM1J2() > Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM1J2() > Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ2 += 3;
                        if (Batalla.GetVidaM2J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetVidaM2J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetVidaM2J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (Batalla.GetDañoM2J1() > Batalla.GetVidaM1J2() && Batalla.GetDañoM1J2() > Batalla.GetVidaM2J1())
                {
                    CoronasJ1 += 1;
                    CoronasJ2 += 1;
                    if (Batalla.GetDañoM1J2() < Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM1J2() < Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM2J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                    else if (Batalla.GetDañoM1J2() > Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM1J2() > Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ2 += 3;
                        if (Batalla.GetVidaM2J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetVidaM2J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetVidaM2J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (Batalla.GetDañoM2J1() < Batalla.GetVidaM1J2() && Batalla.GetDañoM1J2() < Batalla.GetVidaM2J1())
                {
                    CoronasJ1 += 1;
                    CoronasJ2 += 1;
                    if (Batalla.GetDañoM1J2() < Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM1J2() < Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ1 += 3;
                        if (Batalla.GetVidaM2J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                        else
                        {
                            CoronasJ1 += 1;
                            CoronasJ2 += 1;
                            if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ1 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                            {
                                CoronasJ2 += 3;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ1 += 3;
                                }
                                else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                {
                                    CoronasJ2 += 3;
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                }
                            }
                        }
                    }
                    else if (Batalla.GetDañoM1J2() > Batalla.GetDañoM2J1() && Batalla.GetVelocidadAtaqueM1J2() > Batalla.GetVelocidadAtaqueM2J1())
                    {
                        CoronasJ2 += 3;
                        if (Batalla.GetVidaM2J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ1 += 3;
                            if (Batalla.GetVidaM2J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                        else if (Batalla.GetVidaM2J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                        {
                            CoronasJ2 += 3;
                            if (Batalla.GetVidaM2J1() < Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ1 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else if (Batalla.GetVidaM2J1() > Batalla.GetVidaM1J2() && (Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                            {
                                CoronasJ2 += 3;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                            else
                            {
                                CoronasJ1 += 1;
                                CoronasJ2 += 1;
                                if (Batalla.GetDañoM2J1() > Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ1 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else if (Batalla.GetDañoM2J1() < Batalla.GetDañoM1J2() && (Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2()))
                                {
                                    CoronasJ2 += 3;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                                else
                                {
                                    CoronasJ1 += 1;
                                    CoronasJ2 += 1;
                                    if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) > (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ1 += 3;
                                    }
                                    else if ((Batalla.GetAtaqueM2J1() + Batalla.GetDefensaM2J1() + Batalla.GetSinergiaM2J1() + Batalla.GetBalanceM2J1()) < (Batalla.GetAtaqueM1J2() + Batalla.GetDefensaM1J2() + Batalla.GetSinergiaM1J2() + Batalla.GetBalanceM1J2()))
                                    {
                                        CoronasJ2 += 3;
                                    }
                                    else
                                    {
                                        CoronasJ1 += 1;
                                        CoronasJ2 += 1;
                                    }
                                }
                            }
                        }
                    }

                }
            }


            txtContadorJ1.Text = CoronasJ1.ToString();
            txtContadorJ2.Text = CoronasJ2.ToString();
        }
    }
}
