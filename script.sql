-- CRIANDO BANCO DE DADOS
CREATE DATABASE BDBiblioteca;
-- USANDO O BANCO DE DADOS
USE BDBiblioteca;

-- LOGIN
CREATE TABLE tbLogin(
	codUsuario int primary key auto_increment,
    usuario varchar(40),
    senha varchar(40)
);
-- CRIANDO AS TABELAS DO BANCO DE DADOS
CREATE TABLE tbPedidoBiblioteca(
	codPedido int primary key auto_increment,
    tipoLivro varchar(50),
    valorLivro varchar(50),
    valorOpcaoo varchar (50),
    valorTotall varchar(50)
)

-- CONSULTANDO AS TABELAS DO BANCO
SELECT * FROM tbPedidoBiblioteca;
SELECT * FROM tbLogin;