namespace JogodaMemoria
{
    partial class FormDfs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDFFacil = new System.Windows.Forms.Button();
            this.buttonDFMedio = new System.Windows.Forms.Button();
            this.buttonDFDificil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(24, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolher Dificuldade";
            // 
            // buttonDFFacil
            // 
            this.buttonDFFacil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDFFacil.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDFFacil.ForeColor = System.Drawing.Color.OliveDrab;
            this.buttonDFFacil.Location = new System.Drawing.Point(24, 59);
            this.buttonDFFacil.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDFFacil.Name = "buttonDFFacil";
            this.buttonDFFacil.Size = new System.Drawing.Size(244, 51);
            this.buttonDFFacil.TabIndex = 1;
            this.buttonDFFacil.Text = "Normal";
            this.buttonDFFacil.UseVisualStyleBackColor = false;
            this.buttonDFFacil.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDFMedio
            // 
            this.buttonDFMedio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDFMedio.Font = new System.Drawing.Font("SimSun-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDFMedio.ForeColor = System.Drawing.Color.Peru;
            this.buttonDFMedio.Location = new System.Drawing.Point(24, 127);
            this.buttonDFMedio.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDFMedio.Name = "buttonDFMedio";
            this.buttonDFMedio.Size = new System.Drawing.Size(244, 58);
            this.buttonDFMedio.TabIndex = 2;
            this.buttonDFMedio.Text = "Médio";
            this.buttonDFMedio.UseVisualStyleBackColor = false;
            this.buttonDFMedio.Click += new System.EventHandler(this.buttonDFMedio_Click);
            // 
            // buttonDFDificil
            // 
            this.buttonDFDificil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDFDificil.Font = new System.Drawing.Font("Symbol", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDFDificil.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonDFDificil.Location = new System.Drawing.Point(24, 196);
            this.buttonDFDificil.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDFDificil.Name = "buttonDFDificil";
            this.buttonDFDificil.Size = new System.Drawing.Size(244, 58);
            this.buttonDFDificil.TabIndex = 3;
            this.buttonDFDificil.Text = "Difícil";
            this.buttonDFDificil.UseVisualStyleBackColor = false;
            this.buttonDFDificil.Click += new System.EventHandler(this.buttonDFDificil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JogodaMemoria.Properties.Resources._3xw8;
            this.pictureBox1.Location = new System.Drawing.Point(288, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormDfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDFDificil);
            this.Controls.Add(this.buttonDFMedio);
            this.Controls.Add(this.buttonDFFacil);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDfs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDfs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonDFFacil;
        private Button buttonDFMedio;
        private Button buttonDFDificil;
        private PictureBox pictureBox1;
    }
}