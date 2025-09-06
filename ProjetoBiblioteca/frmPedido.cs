using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class frmPedido : Form
    {
        Conexao con = new Conexao();
        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            cmbTipoLivro.DropDownStyle = ComboBoxStyle.DropDownList;

            // Adiciona o placeholder como primeiro item
            cmbTipoLivro.Items.Add("Selecione um livro");

            // Adiciona os livros
            cmbTipoLivro.Items.Add("Dom Quixote");
            cmbTipoLivro.Items.Add("Orgulo e Preconceito");
            cmbTipoLivro.Items.Add("O Pequeno Principe");
            cmbTipoLivro.Items.Add("1984");
            cmbTipoLivro.Items.Add("O Hobit");
            cmbTipoLivro.Items.Add("Moby Dick");
            cmbTipoLivro.Items.Add("Romeu e Julieta");

            // Seleciona o placeholder
            cmbTipoLivro.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chkCapaDura.Checked = false;
            chkBrochura.Checked = false;
            chkBraile.Checked = false;
            chkAutografado.Checked = false;
            chkSimplificada.Checked = false;
            chkLinks.Checked = false;
            chkIlustrado.Checked = false;

            txtOpcionais.Clear();
            txtValorTipo.Clear();
            txtTotal.Clear();
            cmbTipoLivro.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //vefifica os campos
            if (txtValorTipo.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorTipo.Focus();
            }
            else if (txtOpcionais.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtOpcionais.Focus();
            }
            else if (txtTotal.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtTotal.Focus();
            }
            else
            {
                //tratamento de erros
                try
                {
                    //inserindo dados no banco de dados
                    string sql = "insert into tbPedidoBiblioteca(tipoLivro,valorLivro,valorOpcaoo,valorTotall) values(@livro,@vlivro,@vopcao,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@livro", MySqlDbType.Text).Value = cmbTipoLivro.Text;
                    cmd.Parameters.Add("@vlivro", MySqlDbType.Text).Value = txtValorTipo.Text;
                    cmd.Parameters.Add("@vopcao", MySqlDbType.Text).Value = txtOpcionais.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtTotal.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTipoLivro.Text = "";
                    txtValorTipo.Text = "";
                    txtOpcionais.Text = "";
                    txtTotal.Text = "";
                    cmbTipoLivro.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbTipoLivro.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, selecione um tipo de livro válido!");
                return;
            }
            //DECLARANDO AS VARIAVEIS
            double valorTipoLivro = 0, valorOpcao = 0, valorTotal = 0;
            if (cmbTipoLivro.SelectedIndex == 1)
                valorTipoLivro = 10;
            else if (cmbTipoLivro.SelectedIndex == 2)
                valorTipoLivro = 20;
            else if (cmbTipoLivro.SelectedIndex == 3)
                valorTipoLivro = 30;
            else if (cmbTipoLivro.SelectedIndex == 4)
                valorTipoLivro = 40;
            else if (cmbTipoLivro.SelectedIndex == 5)
                valorTipoLivro = 50;
            else if (cmbTipoLivro.SelectedIndex == 6)
                valorTipoLivro = 60;
            else if (cmbTipoLivro.SelectedIndex == 7)
                valorTipoLivro = 70; // Romeu e Julieta

            if (chkCapaDura.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if (chkBrochura.Checked == true)
            {
                valorOpcao = valorOpcao + 6;
            }
            if (chkBraile.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if (chkAutografado.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            if (chkSimplificada.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            if (chkLinks.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            if (chkIlustrado.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            else
            {}
            valorTotal = valorTipoLivro + valorOpcao;
            txtValorTipo.Text = Convert.ToString(valorTipoLivro);
            txtOpcionais.Text = Convert.ToString(valorOpcao);
            txtTotal.Text = Convert.ToString(valorTotal);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
