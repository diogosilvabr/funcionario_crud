using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funcionario_crud
{
    public partial class frmConsultar : Form
    {
        funcionario func = new funcionario();
        public frmConsultar()
        {
            InitializeComponent();
        }

        private void btnBuscaRg_Click(object sender, EventArgs e)
        {
            try
            {
                string rg;
                rg = mskRg.Text;
                func.setRg(rg);

                dgvFuncionarioConsultar.DataSource = func.consultarRg();
            }
            catch
            {
                MessageBox.Show("RG NÃO ENCONTRADO OU INVÁLIDO!");
            }
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            dgvFuncionarioConsultar.DataSource = func.Consultar();
        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal frmCadastro = new frmPrincipal();
            frmCadastro.Show();
        }

        private void alterarDadosCadastraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterar frmAltera = new frmAlterar();
            frmAltera.Show();
        }

        private void excluirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExcluir frmExclui = new frmExcluir();
            frmExclui.Show();
        }

        private void fecharSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
