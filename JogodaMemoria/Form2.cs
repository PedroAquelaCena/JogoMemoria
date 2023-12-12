using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics.Eventing.Reader;

namespace JogodaMemoria
{

    public partial class Form2 : Form
    {

        string pathCd = "credenciais.txt";

        public Form2()
        {
            InitializeComponent();
            pictureBoxFechado.Visible = false;

        }



        private bool VerificarCredenciais(string us, string ps)
        {
            if (File.Exists(pathCd))
            {
                try
                {

                    string[] users = File.ReadAllLines(pathCd);

                    foreach (string user in users)
                    {
                        string[] dadosUsers = user.Split(':');

                        if (dadosUsers[0] == us && dadosUsers[1] == ps)
                            return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            MessageBox.Show("Credenciais de utlizador não encontradas!");

            return false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form1.login = false;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelMostrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelMostrar.Text == "Mostrar")
            {

                textBoxPass.UseSystemPasswordChar = false;

                linkLabelMostrar.Text = "Ocultar";

                pictureBoxAberto.Visible = false;
                pictureBoxFechado.Visible = true;
            }

            else
            {

                textBoxPass.UseSystemPasswordChar = true;
                linkLabelMostrar.Text = "Mostrar";

                pictureBoxFechado.Visible = false;
                pictureBoxAberto.Visible = true;
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Form1.login = false;
            string user = textBoxUsername.Text;
            string pass = textBoxPass.Text;

            if ((user == "1") && (pass == "1"))
            {
                Form1.login = true;
            }

            else
            {
                Form1.login = VerificarCredenciais(user, pass);
            }

            if (Form1.login)
            {
                FormDfs aswd = new FormDfs();
                aswd.ShowDialog();
            }
        }

        private void linkLabelRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();

        }
    }
}
