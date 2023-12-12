namespace JogodaMemoria
{
    public partial class Form1 : Form
    {
        static public bool login = true;

        bool soundOn = false;

        const int nCartas = 20;

        byte nCliques = 0;
        byte restantes = nCartas / 2;

        Button cartaAnterior;

        public Form1()
        {
            
            InitializeComponent();
            buttonMostrar.Visible = true;
            buttonConfig.Visible = true;
            buttonJogarDnv.Visible = false;

            SomInicial();

            DistribuirCartas();
            AtribuirTags();

        }

        private void SomInicial()
        {
            Stream st = Properties.Resources.Beat;

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(st);

            sp.PlayLooping();

            soundOn = true;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

            buttonJogarDnv.Visible = false;
            toolStripStatusLbData.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLbHora.Text = DateTime.Now.ToLongDateString();
            timer1.Enabled = true;
        }

        private void Ocultar()
        {

            foreach (Control x in this.Controls)
                if ((x is Button) && (x.Tag.ToString() == "c"))
                    (x as Button).Visible = false;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLbHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void AtribuirTags()
        {

            int[] tags = new int[nCartas];

            Random rnd = new Random();

            for (int i = 0; i < nCartas; i++)
            {
                tags[i] = i % (nCartas / 2) + 1;
            }


            for (int i = 0; i < nCartas; i++)
            {
                int temp = tags[i];
                int randomIndex = rnd.Next(i, nCartas);
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


        private void buttonMostrar_Click(object sender, EventArgs e)
        {

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                {

                    string s = "_" + x.Tag.ToString();

                    object o = Properties.Resources.ResourceManager.GetObject(s);

                    x.BackgroundImage = (System.Drawing.Image)o;
                }

            Application.DoEvents();

            System.Threading.Thread.Sleep(600);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.traas;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Button cartaAtual = sender as Button;

            string s = "_" + cartaAtual.Tag.ToString();

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
            {
                MessageBox.Show("Parabéns!! Ganhou!!");
                buttonJogarDnv.Visible = true;                
            }    
        }

        private void buttonJogarDnv_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            FormConfig frm = new FormConfig();

            frm.ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DifM asd = new DifM();
            asd.ShowDialog();
        }
    }
}