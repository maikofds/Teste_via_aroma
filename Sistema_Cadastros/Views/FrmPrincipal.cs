using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Cadastros.Views;
using Sistema_Cadastros.Controllers;

namespace Sistema_Cadastros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Click += button2_Click;
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            PessoaController controller = new PessoaController();
            dataGridView1.DataSource = controller.ListarTodas();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPessoas telaCadastro = new FrmPessoas();
            telaCadastro.ShowDialog();
            PessoaController controller = new PessoaController();
            dataGridView1.DataSource = controller.ListarTodas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sistema_Cadastros.Views.FormRelatorio telaRelatorio = new Sistema_Cadastros.Views.FormRelatorio();
            telaRelatorio.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
            dataGridView1.ReadOnly = true;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
                
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                FrmPessoas tela = new FrmPessoas();

                tela.id_pessoa = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                tela.nome_pessoa = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tela.telefone_pessoa = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                tela.ShowDialog();
                PessoaController controller = new PessoaController();
                dataGridView1.DataSource = controller.ListarTodas();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}