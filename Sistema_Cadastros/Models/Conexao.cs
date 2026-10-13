using System;
using MySql.Data.MySqlClient;

namespace Sistema_Cadastros.Models
{
    public class Conexao
    {
        // chave para abrir a porta do teu MySQL no XAMPP
        private string stringConexao = "SERVER=localhost; DATABASE=teste_cadastros; UID=root; PWD=; PORT=3306;";
        private MySqlConnection conexao;

        // Método para ligar à base de dados
        public MySqlConnection Conectar()
        {
            conexao = new MySqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }

        // Método para desligar 
        public void Desconectar()
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}