using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class PermissaoDAL
    {
        public void Inserir(Permissao permissao)
        {
            SqlConnection cn = new SqlConnection(); 

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = @"INSERT INTO Permissao (Desricao) 
                                    VALUES(@Descricao)";


                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao",permissao.Descricao);
                

                cn.Open();
                cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public Usuario Buscar(string _nomeUsuario)
        {
            return new Usuario();
        }
        public void Alterar(Usuario _usuario)
        {

        }
        public void Excluir(int _id)
        {

        }


    }
}