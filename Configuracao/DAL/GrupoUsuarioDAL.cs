using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GrupoUsuarioDal
    {
        public void Inserir(GrupoUsuario grupoUsuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO GrupoUsuario(NomeGrupo)
                                  VALUES (@NomeGrupo)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", grupoUsuario.NomeGrupo);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um novo Grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        public void Alterar(GrupoUsuario _alterar)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"UPDATE GrupoUsuario set NomeGrupo = @NomeGrupo where idGrupoUsuario = @idGrupoUsuario;";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _alterar.NomeGrupo);
                cmd.Parameters.AddWithValue("@idGrupoUsuario", _alterar.Id);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar um Grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(GrupoUsuario _excluir)
        {

            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"Delete From GrupoUsuario where idGrupoUsuario = @idGrupoUsuario;";

                cmd.CommandType = System.Data.CommandType.Text;
                //  cmd.Parameters.AddWithValue("@Descricao", _excluir.Descricao);
                cmd.Parameters.AddWithValue("@idGrupoUsuario", _excluir.Id);


                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um Grupo no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }


        public List<GrupoUsuario> BuscarPorIdUsuario(int _idUsuario)
        {
            List<GrupoUsuario> grupoUsuarios = new List<GrupoUsuario>();
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT GrupoUsuario.Id, GrupoUsuario.GrupoUsuario From GrupoUsuario INNER JOIN UsuarioGrupoUsuario ON GrupoUsuario.Id = UsuarioGrupoUsuario.Id_GrupoUsuario WHERE Id_Usuario = @Id_usuario;";
                cmd.Parameters.AddWithValue("@Id_usuario", _idUsuario);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["GrupoUsuario"].ToString();
                        grupoUsuarios.Add(grupoUsuario);
                    }

                }
                return grupoUsuarios;
            }
            catch (Exception ex)
            {

                throw; new Exception("Ocorreu um erro ao tentar fazer à busca de um grupo.  ");
            }


        }

        public GrupoUsuario BuscarPorNomeGrupoUsuario(string _nomeGrupoUsuario)
        {
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, GrupoUsuario FROM GrupoUsuario WHERE GrupoUsuario like @GrupoUsuario";
                cmd.Parameters.AddWithValue("@GrupoUsuario", "%" + _nomeGrupoUsuario + "%");
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["GrupoUsuario"].ToString();

                    }
                    else
                    {
                        throw new Exception("Grupo não encontrado. ");
                    }
                }
            }
            catch (Exception ex)
            {

                throw; new Exception("Ocoreu um erro ao tentar fazer busca de Descrição. ");
            }

            return grupoUsuario;

        }

        public List<GrupoUsuario> BuscarTodos()
        {
            List<GrupoUsuario> grupoUsuarios = new List<GrupoUsuario>();
            GrupoUsuario grupoUsuario;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, GrupoUsuario FROM GrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["GrupoUsuario"].ToString();
                        grupoUsuarios.Add(grupoUsuario);
                    }
                }
                return grupoUsuarios;

            }
            catch (Exception ex)
            {
                // Console.WriteLine(String.Format("Ocorreu o seguinte erro: {0} ao tentar buscar no banco "));

                throw new Exception("Ocorreu um erro ao tentar buscar todos os Grupos. ");
            }
            finally
            {
                cn.Close();
            }

        }

    }


}

