using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Cadastros.Models;
using Sistema_Cadastros.Controllers;
namespace Sistema_Cadastros.Views
{
    public partial class FrmPessoas : Form
    {
        public int id_pessoa = 0;
        public string nome_pessoa = "";
        public string telefone_pessoa = "";
        public FrmPessoas()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Pessoa novaPessoa = new Pessoa();

            novaPessoa.Id = id_pessoa;
            novaPessoa.Nome = txt_nome.Text;
            novaPessoa.Telefone = txt_telefone.Text;

            PessoaController controller = new PessoaController();

            if (id_pessoa == 0)
            {
                controller.Incluir(novaPessoa);
                MessageBox.Show("Pessoa guardada com sucesso!");
                txt_nome.Clear();
                txt_telefone.Clear();
            }
            else
            {
                controller.Alterar(novaPessoa); // Chama o método para fazer o UPDATE
                MessageBox.Show("Pessoa alterada com sucesso!");
                this.Close(); // Fecha a janela para voltar logo  lista
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                if (id_pessoa != 0) // Só exclui se tivermos selecionado alguém
            {
                var resposta = MessageBox.Show("Tem a certeza que deseja excluir esta pessoa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    PessoaController controller = new PessoaController();
                    controller.Excluir(id_pessoa);

                    MessageBox.Show("Pessoa excluída com sucesso!");
                    this.Close(); // Fecha a janela
                }
            }
        }

        private void FrmPessoas_Load(object sender, EventArgs e)
        {
            if (id_pessoa != 0)
            {
                txt_nome.Text = nome_pessoa;
                txt_telefone.Text = telefone_pessoa;
            }
        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
