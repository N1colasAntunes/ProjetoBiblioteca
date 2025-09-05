namespace ProjetoBiblioteca
{
    partial class frmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.txtCadUsuario = new System.Windows.Forms.TextBox();
            this.lblCadSenha = new System.Windows.Forms.Label();
            this.lblCadUsuario = new System.Windows.Forms.Label();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblCadTelefone = new System.Windows.Forms.Label();
            this.mtbCadTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.Location = new System.Drawing.Point(181, 410);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(132, 61);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastro";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadSenha.Location = new System.Drawing.Point(352, 234);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Size = new System.Drawing.Size(259, 29);
            this.txtCadSenha.TabIndex = 1;
            // 
            // txtCadUsuario
            // 
            this.txtCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadUsuario.Location = new System.Drawing.Point(352, 199);
            this.txtCadUsuario.Name = "txtCadUsuario";
            this.txtCadUsuario.Size = new System.Drawing.Size(259, 29);
            this.txtCadUsuario.TabIndex = 0;
            // 
            // lblCadSenha
            // 
            this.lblCadSenha.AutoSize = true;
            this.lblCadSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadSenha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCadSenha.Location = new System.Drawing.Point(276, 237);
            this.lblCadSenha.Name = "lblCadSenha";
            this.lblCadSenha.Size = new System.Drawing.Size(70, 24);
            this.lblCadSenha.TabIndex = 8;
            this.lblCadSenha.Text = "Senha";
            // 
            // lblCadUsuario
            // 
            this.lblCadUsuario.AutoSize = true;
            this.lblCadUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCadUsuario.Location = new System.Drawing.Point(265, 202);
            this.lblCadUsuario.Name = "lblCadUsuario";
            this.lblCadUsuario.Size = new System.Drawing.Size(81, 24);
            this.lblCadUsuario.TabIndex = 7;
            this.lblCadUsuario.Text = "Usuario";
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTituloUsuario.Location = new System.Drawing.Point(359, 43);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(228, 55);
            this.lblTituloUsuario.TabIndex = 6;
            this.lblTituloUsuario.Text = "Cadastro";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSair.Location = new System.Drawing.Point(650, 410);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(132, 61);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblCadTelefone
            // 
            this.lblCadTelefone.AutoSize = true;
            this.lblCadTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblCadTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadTelefone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCadTelefone.Location = new System.Drawing.Point(253, 272);
            this.lblCadTelefone.Name = "lblCadTelefone";
            this.lblCadTelefone.Size = new System.Drawing.Size(93, 24);
            this.lblCadTelefone.TabIndex = 10;
            this.lblCadTelefone.Text = "Telefone";
            // 
            // mtbCadTelefone
            // 
            this.mtbCadTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCadTelefone.Location = new System.Drawing.Point(352, 272);
            this.mtbCadTelefone.Mask = "(00) 00000-0000";
            this.mtbCadTelefone.Name = "mtbCadTelefone";
            this.mtbCadTelefone.Size = new System.Drawing.Size(259, 29);
            this.mtbCadTelefone.TabIndex = 2;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 506);
            this.Controls.Add(this.mtbCadTelefone);
            this.Controls.Add(this.lblCadTelefone);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCadSenha);
            this.Controls.Add(this.txtCadUsuario);
            this.Controls.Add(this.lblCadSenha);
            this.Controls.Add(this.lblCadUsuario);
            this.Controls.Add(this.lblTituloUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroUsuario";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.TextBox txtCadUsuario;
        private System.Windows.Forms.Label lblCadSenha;
        private System.Windows.Forms.Label lblCadUsuario;
        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblCadTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCadTelefone;
    }
}