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
    public partial class frmLogin : Form
    {
        login loginUsuario = new login();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            try
            {
                loginUsuario.setUsuario(usuario);
                loginUsuario.setSenha(senha);
                loginUsuario.cadastrarUsuario();

                MessageBox.Show("USUÁRIO CADASTRADO!");
            }
            catch
            {
                MessageBox.Show("ERRO PARA CADASTRAR USUÁRIO!");
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            try
            {
                loginUsuario.setUsuario(usuario);
                loginUsuario.setSenha(senha);
                int retorno = loginUsuario.logar();

                if (retorno == 1)
                {
                    FrmInicio inicio = new FrmInicio();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("USUÁRIO OU SENHA INVÁLIDOS!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("ERRO AO LOGAR", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

