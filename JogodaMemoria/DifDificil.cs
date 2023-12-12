using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaMemoria
{
    public partial class DifDificil : Form
    {
        const int NuCartas = 80;
        
        byte nCliques = 0;
        byte restantes = NuCartas / 2;

        Button cartaAnterior;
        public DifDificil()
        {
            InitializeComponent();
            DistribuirCartas();
            AtribuirTags();
        }

        private void DifDificil_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button cartaAtual = sender as Button;

            string s = "r" + cartaAtual.Tag.ToString();

            Object o = Properties.Resources.ResourceManager.GetObject(s);

            cartaAtual.BackgroundImage = (System.Drawing.Image)o;

            if (nCliques == 0)
            {
                cartaAnterior = cartaAtual;

                nCliques++;
            }
            else
                CompararCartas(cartaAtual, cartaAnterior);
        }

        private void CompararCartas(Button cAnt, Button cAtual)
        {
            Application.DoEvents();

            System.Threading.Thread.Sleep(700);


            if (cAnt == cAtual)
            {
                MessageBox.Show("Selecionou a mesma carta!");
                nCliques = 0;
                cAtual.BackgroundImage = Properties.Resources.traas;
            }
            else
            {
                if (cAtual.Tag.ToString() == cAnt.Tag.ToString())
                {
                    restantes--;

                    nCliques = 0;

                    cAnt.Visible = false;
                    cAtual.Visible = false;
                    VerificarSeGanhou();
                }
                else
                {
                    nCliques = 0;
                    cAnt.BackgroundImage = Properties.Resources.traas;
                    cAtual.BackgroundImage = Properties.Resources.traas;
                }
            }
        }

        private void VerificarSeGanhou()
        {
            if (restantes == 0)
                MessageBox.Show("Parabéns!! Ganhou!!");
        }

        private void AtribuirTags()
        {

            int[] tags = new int[NuCartas];

            Random rnd = new Random();

            for (int i = 0; i < NuCartas; i++)
            {
                tags[i] = i % (NuCartas / 2) + 1;
            }


            for (int i = 0; i < NuCartas; i++)
            {
                int temp = tags[i];
                int randomIndex = rnd.Next(i, NuCartas);
                tags[i] = tags[randomIndex];
                tags[randomIndex] = temp;
            }


            int j = 0;
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.Tag = tags[j];
                    j++;
                }
            }
        }

        private void DistribuirCartas()
        {
            foreach (Control x in this.Controls)
                if ((x is Button) && (x.Tag.ToString() == "c"))
                {
                    x.Visible = true;
                    x.BackgroundImage = Properties.Resources.traas;
                }
        }

        private void Ocultar()
        {

            foreach (Control x in this.Controls)
                if ((x is Button) && (x.Tag.ToString() == "c"))
                    (x as Button).Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                {

                    string s = "r" + x.Tag.ToString();

                    object o = Properties.Resources.ResourceManager.GetObject(s);

                    x.BackgroundImage = (System.Drawing.Image)o;
                }

            Application.DoEvents();

            System.Threading.Thread.Sleep(600);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.traas;
        }

        private void DifDificil_Load_1(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
