using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Sistema_Cadastros.Controllers;//pessoa controler

namespace Sistema_Cadastros.Views
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void Form_Relatorio_Load(object sender, EventArgs e)
        {
            PessoaController controller = new PessoaController();
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource fonteDados = new ReportDataSource("Data_Set_Pessoas", controller.ListarTodas());
            reportViewer1.LocalReport.DataSources.Add(fonteDados);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
