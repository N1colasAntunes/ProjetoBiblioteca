namespace ProjetoBiblioteca
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLogar = new System.Windows.Forms.Button();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.lblCadSenha = new System.Windows.Forms.Label();
            this.lblCadUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Tomato;
            this.btnSair.Location = new System.Drawing.Point(494, 361);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(165, 65);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLogar.Location = new System.Drawing.Point(141, 361);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(165, 65);
            this.btnLogar.TabIndex = 3;
            this.btnLogar.Text = "Login";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTituloUsuario.Location = new System.Drawing.Point(325, 20);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(147, 55);
            this.lblTituloUsuario.TabIndex = 7;
            this.lblTituloUsuario.Text = "Login";
            this.lblTituloUsuario.Click += new System.EventHandler(this.lblTituloUsuario_Click);
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginSenha.Location = new System.Drawing.Point(280, 241);
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.PasswordChar = '*';
            this.txtLoginSenha.Size = new System.Drawing.Size(259, 29);
            this.txtLoginSenha.TabIndex = 1;
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsuario.Location = new System.Drawing.Point(280, 204);
            this.txtLoginUsuario.Margin = new System.Windows.Forms.Padding(9);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(259, 29);
            this.txtLoginUsuario.TabIndex = 0;
            // 
            // lblCadSenha
            // 
            this.lblCadSenha.AutoSize = true;
            this.lblCadSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadSenha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCadSenha.Location = new System.Drawing.Point(204, 244);
            this.lblCadSenha.Name = "lblCadSenha";
            this.lblCadSenha.Size = new System.Drawing.Size(70, 24);
            this.lblCadSenha.TabIndex = 15;
            this.lblCadSenha.Text = "Senha";
            // 
            // lblCadUsuario
            // 
            this.lblCadUsuario.AutoSize = true;
            this.lblCadUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCadUsuario.Location = new System.Drawing.Point(193, 209);
            this.lblCadUsuario.Name = "lblCadUsuario";
            this.lblCadUsuario.Size = new System.Drawing.Size(81, 24);
            this.lblCadUsuario.TabIndex = 14;
            this.lblCadUsuario.Text = "Usuario";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLoginSenha);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.lblCadSenha);
            this.Controls.Add(this.lblCadUsuario);
            this.Controls.Add(this.lblTituloUsuario);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.Label lblCadSenha;
        private System.Windows.Forms.Label lblCadUsuario;
    }
}