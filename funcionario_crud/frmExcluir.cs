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
    public partial class frmExcluir : Form
    {
        funcionario func = new funcionario();
            
        public frmExcluir()
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

                dgvFuncionarioExcluir.DataSource = func.consultarRg();
            }
            catch
            {
                MessageBox.Show("FUNCIONÁRIO NÃO ENCONTRADO OU RG INVÁLIDO!");
            }
        }

        private void mskRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal frmCadastro = new frmPrincipal();
            frmCadastro.Show();
        }

        private void consultarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar frmConsulta = new frmConsultar();
            frmConsulta.Show();
        }

        private void fecharSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string rg;
                rg = mskRg.Text;
                func.setRg(rg);
                func.excluir();
                MessageBox.Show("FUNCIONÁRIO DELETADO COM SUCESSO!");
            }
            catch
            {
                MessageBox.Show("ERRO! NÃO FOI POSSÍVEL DELETAR ESTE FUNCIONÁRIO");
            }
        }
    }
}
