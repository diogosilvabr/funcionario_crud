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
    public partial class frmAlterar : Form
    {
        funcionario func = new funcionario();
        public frmAlterar()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscaRg_Click(object sender, EventArgs e)
        {
            try
            {
                string rg;
                rg = mskRg.Text;
                func.setRg(rg);

                dgvFuncionarioAlterar.DataSource = func.consultarRg();
            }
            catch
            {
                MessageBox.Show("FUNCIONÁRIO NÃO ENCONTRADO OU RG INVÁLIDO!");
            }
        }

        private void dgvFuncionarioAlterar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mskRg.Text = dgvFuncionarioAlterar.CurrentRow.Cells[1].Value.ToString();
                txtNome.Text = dgvFuncionarioAlterar.CurrentRow.Cells[2].Value.ToString();
                mskDataAdmissao.Text = dgvFuncionarioAlterar.CurrentRow.Cells[3].Value.ToString();
                mskSalario.Text = dgvFuncionarioAlterar.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("ATRIBUTO NÃO LOCALIZADO");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                string rg, nome, dataAdmissao, salario;
                nome = txtNome.Text;
                dataAdmissao = mskDataAdmissao.Text;
                salario = mskSalario.Text;
                rg = mskRg.Text;
                func.setRg(rg);
                func.setNome(nome);
                func.setDataAdmissao(dataAdmissao);
                func.setSalario(salario);

                func.alterar();
                MessageBox.Show("DADOS ATUALIZADOS COM SUCESSO!");
            }
            catch
            {
                MessageBox.Show("ERRO AO ALTERAR DADOS");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mskRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnBuscaRg_Click_1(object sender, EventArgs e)
        {

        }

        private void consultarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar frmConsulta = new frmConsultar();
            frmConsulta.Show();
        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal frmCadastro = new frmPrincipal();
            frmCadastro.Show();
        }

        private void alterarDadosCadastraisToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
