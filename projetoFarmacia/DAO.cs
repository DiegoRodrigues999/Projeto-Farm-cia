using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace projetoFarmacia
{
    class DAO
    {
        MySqlConnection conexao;
        public string dados;
        public string sql;
        public int[] codigo;
        public string[] nome;
        public string[] telefone;
        public string[] rg;
        public int i;
        public int contador;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=ti18n;Uid=root;Password=");
            try
            {
                conexao.Open();
                MessageBox.Show("Conectado com sucesso!");//Temporariamente   
            }catch(Exception erro)
            {
                MessageBox.Show(erro + "\n\nAlgo deu errado!");
                conexao.Close();             
            }//fim do cacth
        }//fim do construtor

        public void Inserir(int codigo, string nome, string rg, string telefone)
        {
            dados = "('" + codigo + "','" + nome + "','" + telefone + "','" + rg + "')";
            sql = "insert into pessoa(codigo, nome, telefone, cidade, estado) values" + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show(conn.ExecuteNonQuery() + " dado inserido!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do método

        public void preencherVetor()
        {
            string query = "select * from pessoa";

            //instanciar os vetores
            this.codigo = new int[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.rg = new string[100];
            
            //preecher com valores génericos
            for (i=0; i<100; i++)
            {
                codigo[i]   = 0;
                nome[i]     = "";
                telefone[i] = "";
                rg[i] = "";
            }//fim do for

            //criar o comando de colsutar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //listar Todos os dadosque estão no banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;//Utilizar novamente o contar i
            contador = 0;//Contar quantos dados eu tenho no banco
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = "" + leitura["nome"];
                telefone[i] = "" + leitura["telefone"];
                rg[i] = "" + leitura["rg"];
                i++;//Mudando o contador
                contador++;//Contar quantos dados tem no banco
            }//fim do while

            //Encerrar o banco
            leitura.Close();
        }//fim do método

        public int RetornarContagem()
        {
            return contador;
        }//fim do método

        public int SelecionarPorCodigo(int id)
        {
            preencherVetor();

            for (int i = 0; i < RetornarContagem(); i++)
            {
                if (codigo[i] == id)
                {
                    return i;
                }//fim do if
            }//fim do for
            return -1;//Flag = Bandeira|Sinal
    }//fim do metodo

        public void Atualizar(int codigo, string nome, string telefone, string cidade, string estado)
        {
            try
            {
                string query = "update pessoa set nome = '" + nome + "', telefone = '" + telefone +
                               "', rg ='" + rg + "'where codigo = '" + codigo + "''";
                            
                               
                //Preeparar o comando do BD
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show(resultado + " Atualizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Impossível Atualizar \n\n" + erro);
            }
        }//fim do atualizar

        public void Excluir(int id)
        {
            string query = "delete from pessoa where codigo = '" + id + "'";

            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = "" + sql.ExecuteNonQuery();

            MessageBox.Show(resultado + " dado excluído");
        }//fim do excluir



    }//fim da classe
}//fim do método
