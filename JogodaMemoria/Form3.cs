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
using System.Web;

namespace JogodaMemoria
{
    public partial class Form3 : Form
    {
        string pathCd = "credenciais.txt";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private bool UtilizadorJaExistente(string user)
        {
            if (File.Exists(pathCd))
            {
                try
                {
                    string[] users = File.ReadAllLines(pathCd);

                    foreach (string linhaUser in users)
                    {
                        string[] dadosUser = linhaUser.Split(':');

                        if (dadosUser[0] == user)
                            return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            return false;
        }

        private void RegistrarDadosUtiliz(string user, string pass)
        {
            try
            {
                string texto = "\n" + user + ":" + pass;

                File.AppendAllText(pathCd, texto);

                MessageBox.Show("Novo Utilizador Registrado com Sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxPass.Text != "")
            {
                if (textBoxPass.Text == textBoxRepPass.Text)
                    if (!UtilizadorJaExistente(textBoxUsername.Text))
                        RegistrarDadosUtiliz(textBoxUsername.Text, textBoxPass.Text);
                    else
                        MessageBox.Show("Utilizador já existente!!");
            }
            else
            {
                MessageBox.Show("As passwords não coincidem!!");
                textBoxPass.Text = "";
                textBoxRepPass.Text = "";
                textBoxPass.Focus();
            }
            this.Close();
        }
    }
}