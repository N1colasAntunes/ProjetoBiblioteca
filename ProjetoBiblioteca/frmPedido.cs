using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            // Adicionando itens no ComboBox - Tipo de Livro
            cmbTipoLivro.Items.Add("Livro físico");
            cmbTipoLivro.Items.Add("Ebook");
            cmbTipoLivro.Items.Add("Audiolivro");
            cmbTipoLivro.Items.Add("PDF / Download digital");
            cmbTipoLivro.Items.Add("Revista");
            cmbTipoLivro.Items.Add("Mangá / HQ");
            cmbTipoLivro.Items.Add("Livro didático");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
