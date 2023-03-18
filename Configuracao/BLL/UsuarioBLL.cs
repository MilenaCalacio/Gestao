﻿using DAL; 
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace BLL
{
    public class UsuarioBLL
    {
        private string _confirmacaoDeSenha;
        private object _idusuario;
        private object _Id_GrupoUsuario;
        private object id_GrupoUsuario;

        public void ValidarDados(Usuario _usuario, string confirmacaoDeSenha)
        {

            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
                throw new Exception("O nome de usuário deve ter mais de três caracteres.");

            if (_usuario.NomeUsuario.Contains(" "))
                throw new Exception("O Nome de usuário não pode conter espaço");

            if (_usuario.Senha.Contains("1234567"))
                throw new Exception("Não é permitido um número sequencial.");

            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                throw new Exception(" A senha deve ter entre 7 e 11 caracteres.");

            if (_confirmacaoDeSenha != _usuario.Senha)
                throw new Exception("O campo senha e a confirmação de senha não são iguais");


        }  

          public void Inserir (Usuario _usuario, string _confirmacaoDesenha)
        { 
            ValidarDados(_usuario,_confirmacaoDesenha);


               Usuario usuario = new Usuario();
               usuario = BuscarPorNomeUsuario(_usuario.NomeUsuario);
            if (usuario.NomeUsuario == _usuario.NomeUsuario)
                throw new Exception("Já existe um usuário com este nome");
           

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public List<Usuario> BuscarTodos()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            if (string.IsNullOrEmpty(_nomeUsuario))
                throw new Exception("Informe o nome do usuário. ");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);


        }

        public Usuario BuscarPorId(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorId(_id);
        }
        public void Alterar (Usuario _usuario, string _confirmacaoDeSenha)
        {
            ValidarDados(_usuario, _confirmacaoDeSenha);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_usuario);
        }

        public void Excluir (int _id)
        {
          UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir (_id); 
        }
        public void AdicionarGrupo (int _idUsuario, int _idGrupoUsuario)
        {
            if (new UsuarioDAL().ExisteRelacionamento(_idUsuario, id_GrupoUsuario);
            return;

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.AdicionarGrupo(_idUsuario, _idGrupoUsuario);
        }

        public void RemoverGrupoUsuario(int idUsuario, int idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = @"DELETE FROM UsuarioGrupoUsuario
                                      WHERE Id_Usuario = @Id_Usuario
                                   AND Id_GrupoUsuario = @Id_GrupoUsuario";


                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_usuario", _idusuario);
                cmd.Parameters.AddWithValue("@Id_GrupoUsuario", _Id_GrupoUsuario);


                cn.Open();
                cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
    }