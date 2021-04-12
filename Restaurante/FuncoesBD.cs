using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Principal
{
    public class FuncoesBD
    {
        string conexao = "Data Source=SQLExpress; Initial Catalog=Restaurante_SQL;Persist Security Info=True; User ID=sa; Password=12345";

        //MÉTODO PARA GRAVAR DADOS  
        public int gravarForn(int idFornecedor, String rzSocial, String tpForn, String nmComercial, 
            String cnpj, String inscricaoEstadual, String email, String telefone1, String telefone2, String logradouro, String numero, String complemento, String cep)
        {
            int retGravacao = 0;
            SqlConnection conn = new SqlConnection(conexao);

            conn.Open();

            string sqlGravar = "insert into fornecedor(idFornecedor, rzSocial, tpForn, nmComercial, cnpj, inscricaoEstadual, email, telefone1, telefone2, logradouro,numero,complemento, cep ) Values (@idFornecedor, @rzSocial, @tpForn, @nmComercial, @cnpj, @inscricaoEstadual, @email, @telefone1, @telefone2, @logradouro, @numero, @complemento, @cep)";
            SqlCommand cmd = new SqlCommand(sqlGravar, conn);
            cmd.CommandText = sqlGravar;
            //"@" NOME DAS COLUNAS NO BANCO
            cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);
            cmd.Parameters.AddWithValue("@rzSocial",rzSocial);
            cmd.Parameters.AddWithValue("@tpForn",tpForn);
            cmd.Parameters.AddWithValue("@nmComercial",nmComercial);
            cmd.Parameters.AddWithValue("@cnpj",cnpj);
            cmd.Parameters.AddWithValue("@inscricaoEstadual",inscricaoEstadual);
            cmd.Parameters.AddWithValue("@email",email);
            cmd.Parameters.AddWithValue("@telefone1",telefone1);
            cmd.Parameters.AddWithValue("@telefone2",telefone2);
            cmd.Parameters.AddWithValue("@logradouro", logradouro);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@complemento",complemento);
            cmd.Parameters.AddWithValue("@cep",cep);

            conn.Open();

            retGravacao = (int)cmd.ExecuteNonQuery();

            return retGravacao;

        }

        //ALTERAR DADOS
        public int alterarDados(int idFornecedor, String rzSocial, String tpForn, String nmComercial,
            String cnpj, String inscricaoEstadual, String email, String telefone1, String telefone2, String logradouro, String numero, String complemento, String cep)
        {

            int retornaAltera = 0;

            SqlConnection conn = new SqlConnection(conexao);
            string sqlUpd = "update fornecedor set idFornecedor=@idFornecedor, rzSocial=@rzSocial,tpForn=@tpForn, nmComercial=@nmComercial,cnpj=@cnpj,inscricaoEstadual=@inscricaoEstadual,email=@email,telefone1=@telefone1,telefone2=@telefone2,logradouro=@logradouro,numero=@numero,complemento=@complemento,cep=@cep where idFornecedor=@idFornecedor";
            SqlCommand cmd = new SqlCommand(sqlUpd, conn);


            cmd.Parameters.AddWithValue("@idFornecedor", idFornecedor);
            cmd.Parameters.AddWithValue("@rzSocial", rzSocial);
            cmd.Parameters.AddWithValue("@tpForn", tpForn);
            cmd.Parameters.AddWithValue("@nmComercial", nmComercial);
            cmd.Parameters.AddWithValue("@cnpj", cnpj);
            cmd.Parameters.AddWithValue("@inscricaoEstadual", inscricaoEstadual);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone1", telefone1);
            cmd.Parameters.AddWithValue("@telefone2", telefone2);
            cmd.Parameters.AddWithValue("@logradouro", logradouro);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@complemento", complemento);
            cmd.Parameters.AddWithValue("@cep", cep);

            conn.Open();

            retornaAltera = (int)cmd.ExecuteNonQuery();

            return retornaAltera;
        }

        //EXCLUIR DE DADOS 
        public int excluirDados(int idFornecedor)
        {

            int retDel = 0;

            SqlConnection conn = new SqlConnection(conexao);

            string sqlDel = "delete from fornecedor where idFornecedor = '" + idFornecedor + "'";

            SqlCommand cmd = new SqlCommand(sqlDel, conn);



            conn.Open();

            retDel = (int)cmd.ExecuteNonQuery();

            return retDel;

        }
        //###################### CARREGAGRID S/PARAMETRO ##############################

        public DataTable carregaGrid()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(conexao);

            string strSql = "select idFornecedor, rzSocial, tpForn, nmComercial, cnpj, inscricaoEstadual, email, telefone1, telefone2, logradouro, numero, complemento, cep from fornecedor";

            conn.Open();

            SqlCommand cmd = new SqlCommand(strSql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }


        //###################### CARREGAGRID c/PARAMETRO (PESQUISA) ##############################

        public DataTable carregaGrid(string nome)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(conexao);

            string strSql = "select idFornecedor, rzSocial, tpForn, nmComercial, cnpj, inscricaoEstadual, email, telefone1, telefone2, logradouro, numero, complemento, cep from fornecedor where nome like '%" + nome + "%'";

            conn.Open();

            SqlCommand cmd = new SqlCommand(strSql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

    }
}
