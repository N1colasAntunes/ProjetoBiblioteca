using MySql.Data.MySqlClient;
using System;
using System.Data;
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

            //Adiciona o placeholder como primeiro item
            cmbTipoLivro.Items.Add("Selecione um livro");

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

            txtPesquisar.Clear();
            txtCodigo.Clear();
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
                valorTipoLivro = 70;

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
            DialogResult sair = MessageBox.Show("Deseja sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sair == DialogResult.No)
            {
                frmPedido ped = new frmPedido();
                ped.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarPedidos();
        }
        public void CarregarPedidos()
        {
            try
            {
                if (dgvPedido.SelectedRows.Count > 0) // se tem linha selecionada
                {
                    txtCodigo.Text = dgvPedido.SelectedRows[0].Cells[0].Value.ToString();
                    cmbTipoLivro.Text = dgvPedido.SelectedRows[0].Cells[1].Value.ToString();
                    txtValorTipo.Text = dgvPedido.SelectedRows[0].Cells[2].Value.ToString();
                    txtOpcionais.Text = dgvPedido.SelectedRows[0].Cells[3].Value.ToString();
                    txtTotal.Text = dgvPedido.SelectedRows[0].Cells[4].Value.ToString();
                }
                else if (dgvPedido.CurrentRow != null) // se só tem célula clicada
                {
                    txtCodigo.Text = dgvPedido.CurrentRow.Cells[0].Value.ToString();
                    cmbTipoLivro.Text = dgvPedido.CurrentRow.Cells[1].Value.ToString();
                    txtValorTipo.Text = dgvPedido.CurrentRow.Cells[2].Value.ToString();
                    txtOpcionais.Text = dgvPedido.CurrentRow.Cells[3].Value.ToString();
                    txtTotal.Text = dgvPedido.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao carregar dados: " + error.Message);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbPedidoBiblioteca";

                    cmd.Connection = con.ConnectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvPedido.DataSource = dt;
                    con.DesConnectarBD();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                //deixa o datagrid limpo
                dgvPedido.DataSource = null;
            }
        }

        private void chkCapaDura_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkCapaDura.Checked)
                chkBrochura.Checked = false;
        }

        private void chkBrochura_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBrochura.Checked)
                chkCapaDura.Checked = false;
        }

        private void lblPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
