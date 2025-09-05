using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class frmCadastroUsuario : Form
    {
        Conexao con = new Conexao();
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCadUsuario.Text == "" || txtCadSenha.Text == "" || mtbCadTelefone.Text == "")
            {
                MessageBox.Show("Os campos não podem estar vazios");
                txtCadUsuario.Focus();
            }
            else
            {
                try
                {
                    string sql = "insert into tbLogin1(usuario,senha,telefone)values(@user,@senha,@telefone)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtCadUsuario.Text;
                    cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtCadSenha.Text;
                    cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = mtbCadTelefone.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados cadastrados com sucesso");
                    con.DesConnectarBD();
                    this.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtCadTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas dígitos, backspace e alguns símbolos usados em telefone
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != (char)Keys.Back
                && e.KeyChar != ' '
                && e.KeyChar != '('
                && e.KeyChar != ')'
                && e.KeyChar != '-'
                && e.KeyChar != '+')
            {
                e.Handled = true; // bloqueia o caractere
            }
        }
    }
}
