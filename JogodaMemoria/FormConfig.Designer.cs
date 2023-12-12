namespace JogodaMemoria
{
    partial class FormConfig
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
            this.checkBoxMusica = new System.Windows.Forms.CheckBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.pictureBoxSON = new System.Windows.Forms.PictureBox();
            this.pictureBoxSOFF = new System.Windows.Forms.PictureBox();
            this.buttonEncerrar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSOFF)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxMusica
            // 
            this.checkBoxMusica.AutoSize = true;
            this.checkBoxMusica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBoxMusica.Checked = true;
            this.checkBoxMusica.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMusica.Font = new System.Drawing.Font("Yu Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMusica.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkBoxMusica.Location = new System.Drawing.Point(12, 50);
            this.checkBoxMusica.Name = "checkBoxMusica";
            this.checkBoxMusica.Size = new System.Drawing.Size(73, 31);
            this.checkBoxMusica.TabIndex = 0;
            this.checkBoxMusica.Text = "      ";
            this.checkBoxMusica.UseVisualStyleBackColor = true;
            this.checkBoxMusica.CheckedChanged += new System.EventHandler(this.checkBoxMusica_CheckedChanged_1);
            this.checkBoxMusica.Click += new System.EventHandler(this.checkBoxMusica_CheckedChanged);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Sitka Banner", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelMenu.Location = new System.Drawing.Point(12, -22);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(139, 69);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Menu";
            // 
            // pictureBoxSON
            // 
            this.pictureBoxSON.BackgroundImage = global::JogodaMemoria.Properties.Resources.SOn;
            this.pictureBoxSON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSON.Location = new System.Drawing.Point(35, 50);
            this.pictureBoxSON.Name = "pictureBoxSON";
            this.pictureBoxSON.Size = new System.Drawing.Size(50, 31);
            this.pictureBoxSON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSON.TabIndex = 2;
            this.pictureBoxSON.TabStop = false;
            // 
            // pictureBoxSOFF
            // 
            this.pictureBoxSOFF.BackgroundImage = global::JogodaMemoria.Properties.Resources.SOff;
            this.pictureBoxSOFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSOFF.Location = new System.Drawing.Point(35, 50);
            this.pictureBoxSOFF.Name = "pictureBoxSOFF";
            this.pictureBoxSOFF.Size = new System.Drawing.Size(50, 31);
            this.pictureBoxSOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSOFF.TabIndex = 3;
            this.pictureBoxSOFF.TabStop = false;
            // 
            // buttonEncerrar
            // 
            this.buttonEncerrar.BackColor = System.Drawing.Color.Silver;
            this.buttonEncerrar.FlatAppearance.BorderSize = 0;
            this.buttonEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncerrar.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonEncerrar.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonEncerrar.Location = new System.Drawing.Point(12, 113);
            this.buttonEncerrar.Name = "buttonEncerrar";
            this.buttonEncerrar.Size = new System.Drawing.Size(181, 41);
            this.buttonEncerrar.TabIndex = 4;
            this.buttonEncerrar.Text = "Encerrar jogo";
            this.buttonEncerrar.UseVisualStyleBackColor = false;
            this.buttonEncerrar.Click += new System.EventHandler(this.buttonEncerrar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackgroundImage = global::JogodaMemoria.Properties.Resources.istockphoto_1210969290_612x612_removebg_preview;
            this.buttonFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFechar.FlatAppearance.BorderSize = 0;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Location = new System.Drawing.Point(146, -1);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(60, 59);
            this.buttonFechar.TabIndex = 5;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(205, 162);
            this.ControlBox = false;
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonEncerrar);
            this.Controls.Add(this.pictureBoxSOFF);
            this.Controls.Add(this.pictureBoxSON);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.checkBoxMusica);
            this.MaximizeBox = false;
            this.Name = "FormConfig";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSOFF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBoxMusica;
        private Label labelMenu;
        private PictureBox pictureBoxSON;
        private PictureBox pictureBoxSOFF;
        private Button buttonEncerrar;
        private Button buttonFechar;
    }
}