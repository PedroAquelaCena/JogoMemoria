namespace JogodaMemoria
{
    partial class Form3
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
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxRepPass = new System.Windows.Forms.TextBox();
            this.labelCriarContaTXT = new System.Windows.Forms.Label();
            this.labelintroduzirDados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPass.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPass.Location = new System.Drawing.Point(40, 136);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(190, 22);
            this.textBoxPass.TabIndex = 39;
            this.textBoxPass.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.LightGray;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Location = new System.Drawing.Point(40, 98);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(190, 22);
            this.textBoxUsername.TabIndex = 38;
            this.textBoxUsername.Text = "Username";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonCancelar.Location = new System.Drawing.Point(153, 212);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(86, 33);
            this.buttonCancelar.TabIndex = 37;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistrar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonRegistrar.Location = new System.Drawing.Point(40, 212);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(93, 33);
            this.buttonRegistrar.TabIndex = 36;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textBoxRepPass
            // 
            this.textBoxRepPass.BackColor = System.Drawing.Color.LightGray;
            this.textBoxRepPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRepPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxRepPass.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRepPass.Location = new System.Drawing.Point(40, 175);
            this.textBoxRepPass.Name = "textBoxRepPass";
            this.textBoxRepPass.Size = new System.Drawing.Size(190, 22);
            this.textBoxRepPass.TabIndex = 42;
            this.textBoxRepPass.Text = "Repetir Password";
            // 
            // labelCriarContaTXT
            // 
            this.labelCriarContaTXT.AutoSize = true;
            this.labelCriarContaTXT.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCriarContaTXT.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelCriarContaTXT.Location = new System.Drawing.Point(23, 9);
            this.labelCriarContaTXT.Name = "labelCriarContaTXT";
            this.labelCriarContaTXT.Size = new System.Drawing.Size(216, 42);
            this.labelCriarContaTXT.TabIndex = 43;
            this.labelCriarContaTXT.Text = "Criar Conta";
            // 
            // labelintroduzirDados
            // 
            this.labelintroduzirDados.AutoSize = true;
            this.labelintroduzirDados.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelintroduzirDados.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelintroduzirDados.Location = new System.Drawing.Point(23, 63);
            this.labelintroduzirDados.Name = "labelintroduzirDados";
            this.labelintroduzirDados.Size = new System.Drawing.Size(230, 19);
            this.labelintroduzirDados.TabIndex = 44;
            this.labelintroduzirDados.Text = "Introduza os dados necessários";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(277, 267);
            this.Controls.Add(this.labelintroduzirDados);
            this.Controls.Add(this.labelCriarContaTXT);
            this.Controls.Add(this.textBoxRepPass);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrar);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxPass;
        private TextBox textBoxUsername;
        private Button buttonCancelar;
        private Button buttonRegistrar;
        private TextBox textBoxRepPass;
        private Label labelCriarContaTXT;
        private Label labelintroduzirDados;
    }
}