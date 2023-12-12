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
    public partial class FormDfs : Form
    {
        public FormDfs()
        {
            InitializeComponent();
        }

        private void FormDfs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 asd = new Form1();
            asd.ShowDialog();
        }

        private void buttonDFMedio_Click(object sender, EventArgs e)
        {
            DifM asd = new DifM();
            asd.ShowDialog();
        }

        private void buttonDFDificil_Click(object sender, EventArgs e)
        {
            DifDificil asd = new DifDificil();
            asd.ShowDialog();
        }
    }
}
