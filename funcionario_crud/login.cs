using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;   

namespace funcionario_crud
{
    class login : conexao
    {
        private string Usuario;
        private string Senha;

        public string getUsuario()
        {
            return this.Usuario;
        }
        public void setUsuario(string Usuario)
        {
            this.Usuario = Usuario;
        }
        public string getSenha()
        {
            return this.Senha;
        }
        public void setSenha(string Senha)
        {
            this.Senha = Senha;
        }
        public void cadastrarUsuario()
        {
            string query = "INSERT INTO usuarios(usuario,senha) VALUES('" +
                            this.Usuario + "' , '" + this.Senha + "') ";

                if(this.abrirConexao() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conectar);
                    cmd.ExecuteNonQuery();
                    this.fecharConexao();
                }
        }
        public int logar()
        {
            this.abrirConexao();
            string query = "SELECT count(usuario) FROM usuarios where usuario= '"
                + this.getUsuario() + "' and senha= '" + this.getSenha() + "'";

            MySqlCommand cmd = new MySqlCommand(query, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            Int32 resultadoQuery = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            int valorLogin;
            valorLogin = resultadoQuery;
            this.fecharConexao();
            return valorLogin;
        }
    }
}
