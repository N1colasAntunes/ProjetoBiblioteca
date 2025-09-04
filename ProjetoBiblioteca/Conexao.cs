using MySql.Data.MySqlClient;
using System;

namespace ProjetoBiblioteca
{
    class Conexao
    {
        //crindo uma instancia
        //instancia é o ato de apelidar, mysqlconection vai receber o nome con
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=BDProjeto;user=root;pwd=12345678"); //ísso atras é a string de conexao.
        //data source, local       intial catalog é o nome do banco,    usuario e senha
        //variavel estatica, fixa, eu posso reutilizar, pode dar erro e eu reutilizar ela, ela muda de valor quando eu quiser
        public static string msg;
        //o nome do metodo é conectar, desconectar
        public MySqlConnection ConnectarBD()
        {
            //tratamento de erros
            //se nao tivesse e desse errado o sistema crasharia.
            //assim como a tela azul do windows
            try
            {
                con.Open();

            }
            //se nao der certo ele entra na exeção, erro, e na msg ele vai mostrar em erro.message qual é o erro
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return con;
        }
        //ao sair de casa tem que fechar a porta, segurança
        public MySqlConnection DesConnectarBD()
        {
            try
            {
                con.Close();

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se desconectar" + erro.Message;
            }
            return con;
        }
    }
}