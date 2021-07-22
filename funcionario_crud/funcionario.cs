using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace funcionario_crud
{
    class funcionario : conexao
    {
        private string rg;
        private string nome;
        private string dataAdmissao;
        private string salario;

        public string getRg()
        {
            return this.rg;
        }
        public void setRg(string rg)
        {
            this.rg = rg;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getDataAdmissao()
        {
            return this.dataAdmissao;
        }
        public void setDataAdmissao(string dataAdmissao)
        {
            this.dataAdmissao = dataAdmissao;
        }
        public string getSalario()
        {
            return this.salario;
        }
        public void setSalario(string salario)
        {
            this.salario = salario;
        }
        public void inserir()
        {
            string query = "INSERT INTO Funcionarios(rg,nome,dataAdmissao,salario)VALUES" +
            "('" + this.rg + "' , '" + this.nome + "' , '" + this.dataAdmissao + "' , '" + this.salario + "' )";

            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
        public DataTable Consultar()
        {
            this.abrirConexao();
            string query = "SELECT * FROM Funcionarios";
            MySqlCommand cmd = new MySqlCommand(query, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(query, conectar);
            this.fecharConexao();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable consultarRg()
        {
            this.abrirConexao();
            string query = "SELECT * FROM Funcionarios where rg= '" +
                this.getRg() + "'";

            MySqlCommand cmd = new MySqlCommand(query, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void excluir()
        {
            string query = "DELETE FROM Funcionarios where rg= '" +
                            this.rg + "'";

            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }
        }
        public void alterar()
        {
            string query = "UPDATE clientes SET nome= '" + this.nome + "', dataAdmissao = '"
                           + this.dataAdmissao + "' , salario= '" + this.salario +
                           "'where rg='" + this.rg + "'";

            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }

        }
    }
}
