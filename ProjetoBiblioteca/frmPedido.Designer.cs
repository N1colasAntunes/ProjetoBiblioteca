namespace ProjetoBiblioteca
{
    partial class frmPedido
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
            this.lblBibliotecaVirtual = new System.Windows.Forms.Label();
            this.cmbTipoLivro = new System.Windows.Forms.ComboBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chkIlustrado = new System.Windows.Forms.CheckBox();
            this.chkCapaDura = new System.Windows.Forms.CheckBox();
            this.chkBraile = new System.Windows.Forms.CheckBox();
            this.chkAutografado = new System.Windows.Forms.CheckBox();
            this.chkSimplificada = new System.Windows.Forms.CheckBox();
            this.lblValorTipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtValorTipo = new System.Windows.Forms.TextBox();
            this.txtOpcionais = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.chkLinks = new System.Windows.Forms.CheckBox();
            this.chkBrochura = new System.Windows.Forms.CheckBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grpOpcionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBibliotecaVirtual
            // 
            this.lblBibliotecaVirtual.AutoSize = true;
            this.lblBibliotecaVirtual.BackColor = System.Drawing.Color.Transparent;
            this.lblBibliotecaVirtual.Font = new System.Drawing.Font("Reem Kufi", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibliotecaVirtual.ForeColor = System.Drawing.Color.White;
            this.lblBibliotecaVirtual.Location = new System.Drawing.Point(-1, -13);
            this.lblBibliotecaVirtual.Name = "lblBibliotecaVirtual";
            this.lblBibliotecaVirtual.Size = new System.Drawing.Size(335, 67);
            this.lblBibliotecaVirtual.TabIndex = 0;
            this.lblBibliotecaVirtual.Text = "Biblioteca Virtual";
            // 
            // cmbTipoLivro
            // 
            this.cmbTipoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoLivro.FormattingEnabled = true;
            this.cmbTipoLivro.Location = new System.Drawing.Point(44, 80);
            this.cmbTipoLivro.Name = "cmbTipoLivro";
            this.cmbTipoLivro.Size = new System.Drawing.Size(190, 28);
            this.cmbTipoLivro.TabIndex = 0;
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkBrochura);
            this.grpOpcionais.Controls.Add(this.chkLinks);
            this.grpOpcionais.Controls.Add(this.chkSimplificada);
            this.grpOpcionais.Controls.Add(this.chkAutografado);
            this.grpOpcionais.Controls.Add(this.chkBraile);
            this.grpOpcionais.Controls.Add(this.chkCapaDura);
            this.grpOpcionais.Controls.Add(this.chkIlustrado);
            this.grpOpcionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpcionais.Location = new System.Drawing.Point(34, 207);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Size = new System.Drawing.Size(200, 213);
            this.grpOpcionais.TabIndex = 2;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "Opcionais";
            // 
            // chkIlustrado
            // 
            this.chkIlustrado.AutoSize = true;
            this.chkIlustrado.Location = new System.Drawing.Point(29, 168);
            this.chkIlustrado.Name = "chkIlustrado";
            this.chkIlustrado.Size = new System.Drawing.Size(82, 19);
            this.chkIlustrado.TabIndex = 0;
            this.chkIlustrado.Text = "Ilustrado";
            this.chkIlustrado.UseVisualStyleBackColor = true;
            // 
            // chkCapaDura
            // 
            this.chkCapaDura.AutoSize = true;
            this.chkCapaDura.Location = new System.Drawing.Point(29, 30);
            this.chkCapaDura.Name = "chkCapaDura";
            this.chkCapaDura.Size = new System.Drawing.Size(92, 19);
            this.chkCapaDura.TabIndex = 1;
            this.chkCapaDura.Text = "Capa dura";
            this.chkCapaDura.UseVisualStyleBackColor = true;
            // 
            // chkBraile
            // 
            this.chkBraile.AutoSize = true;
            this.chkBraile.Location = new System.Drawing.Point(29, 76);
            this.chkBraile.Name = "chkBraile";
            this.chkBraile.Size = new System.Drawing.Size(122, 19);
            this.chkBraile.TabIndex = 2;
            this.chkBraile.Text = "Livro em braile";
            this.chkBraile.UseVisualStyleBackColor = true;
            // 
            // chkAutografado
            // 
            this.chkAutografado.AutoSize = true;
            this.chkAutografado.Location = new System.Drawing.Point(29, 99);
            this.chkAutografado.Name = "chkAutografado";
            this.chkAutografado.Size = new System.Drawing.Size(103, 19);
            this.chkAutografado.TabIndex = 3;
            this.chkAutografado.Text = "Autografado";
            this.chkAutografado.UseVisualStyleBackColor = true;
            // 
            // chkSimplificada
            // 
            this.chkSimplificada.AutoSize = true;
            this.chkSimplificada.Location = new System.Drawing.Point(29, 122);
            this.chkSimplificada.Name = "chkSimplificada";
            this.chkSimplificada.Size = new System.Drawing.Size(152, 19);
            this.chkSimplificada.TabIndex = 4;
            this.chkSimplificada.Text = "Versão simplificada";
            this.chkSimplificada.UseVisualStyleBackColor = true;
            // 
            // lblValorTipo
            // 
            this.lblValorTipo.AutoSize = true;
            this.lblValorTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTipo.Location = new System.Drawing.Point(414, 38);
            this.lblValorTipo.Name = "lblValorTipo";
            this.lblValorTipo.Size = new System.Drawing.Size(84, 16);
            this.lblValorTipo.TabIndex = 3;
            this.lblValorTipo.Text = "Valor Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opcionais:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(684, 38);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // txtValorTipo
            // 
            this.txtValorTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTipo.Location = new System.Drawing.Point(407, 68);
            this.txtValorTipo.Name = "txtValorTipo";
            this.txtValorTipo.Size = new System.Drawing.Size(100, 22);
            this.txtValorTipo.TabIndex = 6;
            // 
            // txtOpcionais
            // 
            this.txtOpcionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcionais.Location = new System.Drawing.Point(532, 68);
            this.txtOpcionais.Name = "txtOpcionais";
            this.txtOpcionais.Size = new System.Drawing.Size(100, 22);
            this.txtOpcionais.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(659, 68);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 8;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(584, 166);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(154, 22);
            this.txtPesquisa.TabIndex = 9;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(490, 164);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(82, 20);
            this.lblPesquisar.TabIndex = 10;
            this.lblPesquisar.Text = "Pesquisa";
            // 
            // dgvPedido
            // 
            this.dgvPedido.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(292, 207);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(446, 139);
            this.dgvPedido.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(406, 370);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 43);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(516, 370);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 43);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(292, 370);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 43);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(630, 370);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 43);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // chkLinks
            // 
            this.chkLinks.AutoSize = true;
            this.chkLinks.Location = new System.Drawing.Point(29, 145);
            this.chkLinks.Name = "chkLinks";
            this.chkLinks.Size = new System.Drawing.Size(140, 19);
            this.chkLinks.TabIndex = 5;
            this.chkLinks.Text = "Com links digitais";
            this.chkLinks.UseVisualStyleBackColor = true;
            // 
            // chkBrochura
            // 
            this.chkBrochura.AutoSize = true;
            this.chkBrochura.Location = new System.Drawing.Point(29, 53);
            this.chkBrochura.Name = "chkBrochura";
            this.chkBrochura.Size = new System.Drawing.Size(120, 19);
            this.chkBrochura.TabIndex = 6;
            this.chkBrochura.Text = "Capa brochura";
            this.chkBrochura.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(359, 166);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(75, 22);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(288, 164);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 20);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Codigo";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtOpcionais);
            this.Controls.Add(this.txtValorTipo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValorTipo);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.cmbTipoLivro);
            this.Controls.Add(this.lblBibliotecaVirtual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBibliotecaVirtual;
        private System.Windows.Forms.ComboBox cmbTipoLivro;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.CheckBox chkSimplificada;
        private System.Windows.Forms.CheckBox chkAutografado;
        private System.Windows.Forms.CheckBox chkBraile;
        private System.Windows.Forms.CheckBox chkCapaDura;
        private System.Windows.Forms.CheckBox chkIlustrado;
        private System.Windows.Forms.Label lblValorTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtValorTipo;
        private System.Windows.Forms.TextBox txtOpcionais;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox chkBrochura;
        private System.Windows.Forms.CheckBox chkLinks;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}