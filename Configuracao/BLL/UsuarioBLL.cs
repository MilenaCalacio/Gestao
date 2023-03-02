using DAL; 
using Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BLL
{
    public class UsuarioBLL
    {
        public void ValidarDados(Usuario _usuario)
        {

            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
                throw new Exception("O nome de usuário deve ter mais de três caracteres.");

            if (_usuario.NomeUsuario.Contains(" "))
                throw new Exception("O Nome de usuário não pode conter espaço");

            if (_usuario.Senha.Contains("1234567"))
                throw new Exception("Não é permitido um número sequencial.");

            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                throw new Exception(" A senha deve ter entre 7 e 11 caracteres.");

        }  

          public void Inserir (Usuario _usuario)
        { 
            ValidarDados(_usuario);


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
        public void Alterar (Usuario _usuario)
        {
            ValidarDados(_usuario);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_usuario);
        }
        public void Excluir (int _id)
        {
          UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir (_id); 
        }
    }
}