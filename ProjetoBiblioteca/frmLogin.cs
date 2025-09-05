using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class frmLogin : Form
    {
        Conexao con = new Conexao();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblTituloUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtLoginUsuario.Text == "" || txtLoginSenha.Text == "")
            {
                MessageBox.Show("Os campos não podem estar vazios");
                txtLoginUsuario.Focus();
            }
            else
            {
                try
                {
                    // Consulta no banco para verificar usuário e senha
                    string sql = "SELECT * FROM tbLogin1 WHERE usuario = @user AND senha = @senha";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());

                    cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtLoginUsuario.Text;
                    cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtLoginSenha.Text;

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)// se deu certo
                    {
                        MessageBox.Show("Login realizado com sucesso!");
                        new frmPedido().Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!");
                        txtLoginSenha.Clear();
                        txtLoginUsuario.Clear();
                        txtLoginUsuario.Focus();
                    }
                    reader.Close();
                    con.DesConnectarBD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao autenticar: " + ex.Message);
                }
            }
        }
    }
}
