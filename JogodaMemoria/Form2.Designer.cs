namespace JogodaMemoria
{
    partial class Form2
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
            this.pictureBoxFechado = new System.Windows.Forms.PictureBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.linkLabelMostrar = new System.Windows.Forms.LinkLabel();
            this.pictureBoxAberto = new System.Windows.Forms.PictureBox();
            this.linkLabelRegistrar = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAberto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFechado
            // 
            this.pictureBoxFechado.BackgroundImage = global::JogodaMemoria.Properties.Resources.a818530d33814f2eb606a5c606535feb_removebg_preview;
            this.pictureBoxFechado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFechado.Location = new System.Drawing.Point(216, -28);
            this.pictureBoxFechado.Name = "pictureBoxFechado";
            this.pictureBoxFechado.Size = new System.Drawing.Size(423, 217);
            this.pictureBoxFechado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFechado.TabIndex = 27;
            this.pictureBoxFechado.TabStop = false;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEntrar.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEntrar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonEntrar.Location = new System.Drawing.Point(36, 131);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(83, 33);
            this.buttonEntrar.TabIndex = 28;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonCancelar.Location = new System.Drawing.Point(147, 131);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(86, 33);
            this.buttonCancelar.TabIndex = 29;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.LightGray;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Location = new System.Drawing.Point(36, 37);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(190, 22);
            this.textBoxUsername.TabIndex = 30;
            this.textBoxUsername.Text = "Username";
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPass.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPass.Location = new System.Drawing.Point(36, 74);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(190, 22);
            this.textBoxPass.TabIndex = 31;
            this.textBoxPass.Text = "*********";
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // linkLabelMostrar
            // 
            this.linkLabelMostrar.AutoSize = true;
            this.linkLabelMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelMostrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelMostrar.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelMostrar.Location = new System.Drawing.Point(232, 76);
            this.linkLabelMostrar.Name = "linkLabelMostrar";
            this.linkLabelMostrar.Size = new System.Drawing.Size(70, 20);
            this.linkLabelMostrar.TabIndex = 32;
            this.linkLabelMostrar.TabStop = true;
            this.linkLabelMostrar.Text = "Mostrar";
            this.linkLabelMostrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMostrar_LinkClicked);
            // 
            // pictureBoxAberto
            // 
            this.pictureBoxAberto.BackgroundImage = global::JogodaMemoria.Properties.Resources.Goomba3d_removebg_preview;
            this.pictureBoxAberto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAberto.Location = new System.Drawing.Point(307, -8);
            this.pictureBoxAberto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAberto.Name = "pictureBoxAberto";
            this.pictureBoxAberto.Size = new System.Drawing.Size(225, 181);
            this.pictureBoxAberto.TabIndex = 33;
            this.pictureBoxAberto.TabStop = false;
            // 
            // linkLabelRegistrar
            // 
            this.linkLabelRegistrar.AutoSize = true;
            this.linkLabelRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelRegistrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelRegistrar.LinkColor = System.Drawing.Color.SlateGray;
            this.linkLabelRegistrar.Location = new System.Drawing.Point(147, 99);
            this.linkLabelRegistrar.Name = "linkLabelRegistrar";
            this.linkLabelRegistrar.Size = new System.Drawing.Size(75, 13);
            this.linkLabelRegistrar.TabIndex = 34;
            this.linkLabelRegistrar.TabStop = true;
            this.linkLabelRegistrar.Text = "Registrar-se";
            this.linkLabelRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistrar_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 198);
            this.Controls.Add(this.linkLabelRegistrar);
            this.Controls.Add(this.pictureBoxAberto);
            this.Controls.Add(this.linkLabelMostrar);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.pictureBoxFechado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAberto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxFechado;
        private Button buttonEntrar;
        private Button buttonCancelar;
        private TextBox textBoxUsername;
        private TextBox textBoxPass;
        private LinkLabel linkLabelMostrar;
        private PictureBox pictureBoxAberto;
        private LinkLabel linkLabelRegistrar;
    }
}