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
    public partial class frmPrincipal : Form
    {
        funcionario func = new funcionario();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string rg, nome, dataAdmissao, salario;
            rg = mskRg.Text;
            nome = txtNome.Text;
            dataAdmissao = mskDataAdmissao.Text;
            salario = mskSalario.Text;
            try
            {
                func.setRg(rg);
                func.setNome(nome);
                func.setDataAdmissao(dataAdmissao);
                func.setSalario(salario);

                func.inserir();
                MessageBox.Show("Funcionário inserido com sucesso!");
            }
            catch
            {
                MessageBox.Show("Falha ao inserir o funcionário!");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskRg.Clear();
            mskDataAdmissao.Clear();
            txtNome.Clear();
            mskSalario.Clear();

        }

        private void consultarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar frmConsulta = new frmConsultar();
            frmConsulta.Show();
        }
    }
}
