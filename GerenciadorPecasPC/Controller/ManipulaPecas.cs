using GerenciadorPecasPC.Model;
using GerenciadorPecasPC.View;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace GerenciadorPecasPC.Controller
{
    internal class ManipulaPecas
    {
        public void CadPecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pcadastrarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("Pecas", Pecas.Peca);
                cmd.Parameters.AddWithValue("Marcas", Pecas.Marca);
                cmd.Parameters.AddWithValue("Capacidades", Pecas.Capacidade);

                SqlParameter nv = cmd.Parameters.Add("IdPecas", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça cadastrada com sucesso! Deseja cadastrar outra Peça?", "Novo Registo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    TelaCadastroPecas telaCadastroPecas = new TelaCadastroPecas();
                    telaCadastroPecas.AbrirCadastro();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }

            
        }


        public void BuscaPecasCod()
        {



            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pBuscaPecasCodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("IdPecas", Pecas.Codigo);
                cn.Open();

                var registros = cmd.ExecuteReader();

                if (registros.Read())
                {
                    Pecas.Codigo = Convert.ToInt32(registros["IdPecas"]);
                    Pecas.Peca = (string)registros["Pecas"];
                    Pecas.Marca = (string)registros["Marcas"];
                    Pecas.Capacidade = (string)registros["Capacidades"];
                }
                else
                {
                    Pecas.Codigo = 0;
                    Pecas.Peca = "";
                    Pecas.Marca = "";
                    Pecas.Capacidade = "";
                    MessageBox.Show("Peça não encontrada!!!", "Pesquisa Código");
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void BuscaPecsNome()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pBuscaPecasNome", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("Pecas", Pecas.Peca);
                cn.Open();

                var registros = cmd.ExecuteReader();
                if (registros.Read())
                {
                    Pecas.Codigo = Convert.ToInt32(registros["IdPecas"]);
                    Pecas.Peca = (string)registros["Pecas"];
                    Pecas.Marca = (string)registros["Marcas"];
                    Pecas.Capacidade = (string)registros["Capacidades"];
                }
                else
                {
                    Pecas.Codigo = 0;
                    Pecas.Peca = "";
                    Pecas.Marca = "";
                    Pecas.Capacidade = "";
                    MessageBox.Show("Peça não encontrada!!!", "Pesquisa Código");
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void DeletarPec()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPecas", Pecas.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Tem certeza que deseja deletar?", "Deletar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
                {
                    resposta = MessageBox.Show("Peça deletada com sucesso");

                }
                else
                {
                    return;
                }







            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AlterarPec()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPecas", Pecas.Codigo);
                cmd.Parameters.AddWithValue("@Pecas", Pecas.Peca);
                cmd.Parameters.AddWithValue("@Marcas", Pecas.Marca);
                cmd.Parameters.AddWithValue("@Capacidades", Pecas.Capacidade);

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Tem certeza que deseja alterar?", "Alterar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    resposta = MessageBox.Show("Peça alterada com sucesso");

                }
                else
                {
                    return;
                }

                Pecas.Codigo = 0;
                Pecas.Peca = "";
                Pecas.Marca = "";
                Pecas.Capacidade = "";
            }
            catch (Exception)
            {

                throw;
            }
        }






    }
}
