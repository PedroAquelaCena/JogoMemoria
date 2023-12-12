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
    public partial class FormConfig : Form
    {
        bool soundOn = false;

        static Stream st = Properties.Resources.Beat;

        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(st);

        public FormConfig()
        {
            InitializeComponent();

            pictureBoxSOFF.Visible = false;
            pictureBoxSON.Visible = true;

            soundOn = true;
        }

        private void SomInicial()
        {

            sp.PlayLooping();

            soundOn = true;
        }

        private void buttonEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxMusica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMusica.Checked)
            {
                pictureBoxSON.Visible = true;
                pictureBoxSOFF.Visible = false;

                sp.PlayLooping();
                soundOn = true;
            }
            else
            {
                pictureBoxSON.Visible = false;
                pictureBoxSOFF.Visible = true;

                sp.Stop();
                soundOn = false;
            }
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDfs asd = new FormDfs();
            asd.ShowDialog();
        }

        private void checkBoxMusica_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
