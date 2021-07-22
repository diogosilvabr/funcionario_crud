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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void excluirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fecharSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void consultarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void excluirFuncionárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmExcluir frmExclui = new frmExcluir();
            frmExclui.Show();
        }
    }
}
