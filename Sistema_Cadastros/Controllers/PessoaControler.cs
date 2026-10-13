using System;
using System.Data;
using MySql.Data.MySqlClient;
using Sistema_Cadastros.Models; // Permite aceder à Conexão e à Pessoa

namespace Sistema_Cadastros.Controllers
{
    public class PessoaController
    {
        private Conexao bd = new Conexao();

        // 1. Método para INCLUIR uma pessoa na base de dados
        public void Incluir(Pessoa pessoa)
        {
            try
            {
                MySqlConnection conn = bd.Conectar();

                string sql = "INSERT INTO pessoas (nome, telefone) VALUES (@nome, @telefone)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@telefone", pessoa.Telefone);

                cmd.ExecuteNonQuery(); // Executa a gravação
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao incluir pessoa: " + ex.Message);
            }
            finally
            {
                bd.Desconectar(); // Fecha a porta para não encravar o XAMPP
            }
        }

        // 2. Método para LISTAR as pessoas e preencher a grelha (DataGridView) e o Relatório
        public DataTable ListarTodas()
        {
            DataTable tabela = new DataTable();
            try
            {
                MySqlConnection conn = bd.Conectar();

                string sql = "SELECT id AS 'ID', nome AS 'Nome', telefone AS 'Telefone' FROM pessoas";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar pessoas: " + ex.Message);
            }
            finally
            {
                bd.Desconectar();
            }
            return tabela;
        }
        // 3. Método para ALTERAR uma pessoa
        public void Alterar(Pessoa pessoa)
        {
            try
            {
                MySqlConnection conn = bd.Conectar();

                string sql = "UPDATE pessoas SET nome = @nome, telefone = @telefone WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                cmd.Parameters.AddWithValue("@id", pessoa.Id); // Verifica se no teu model Pessoa é Id (maiúsculo) ou id (minúsculo)

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar pessoa: " + ex.Message);
            }
            finally
            {
                bd.Desconectar();
            }
        }

        // 4. Método para EXCLUIR uma pessoa
        public void Excluir(int Id)
        {
            try
            {
                MySqlConnection conn = bd.Conectar();

                string sql = "DELETE FROM pessoas WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", Id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir pessoa: " + ex.Message);
            }
            finally
            {
                bd.Desconectar();
            }
        }
    }
}