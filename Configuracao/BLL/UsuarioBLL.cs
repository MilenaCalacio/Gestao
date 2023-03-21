using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario, string _confirmacaoDeSenha)
        {
            ValidarDados(_usuario, _confirmacaoDeSenha);

            Usuario usuario = new Usuario();
            usuario = BuscarPorNomeUsuario(_usuario.NomeUsuario);
            if (usuario.NomeUsuario == _usuario.NomeUsuario)
                throw new Exception("Já existe um usuário com este nome! ");

            //TODO: Validar se já existe um usuário com nome existente.

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public void ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (_usuario.NomeUsuario.Length <= 4 || _usuario.NomeUsuario.Length >= 50)
                throw new Exception(" O nome de usuário deve ter mais de três caracteres. ");

            if (_usuario.NomeUsuario.Contains(" "))
                throw new Exception(" O nome de usuário não pode conter espaço em branco. ");

            if (_usuario.Senha.Contains("1234567"))
                throw new Exception(" Não é permitido um número sequencial. ");

            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                throw new Exception(" A senha deve ter entre 7 e 11 caracteres. ");

            if (_confirmacaoDeSenha != _usuario.Senha)
                throw new Exception("Senha de confirmação errada. ");

        }

        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            if (String.IsNullOrEmpty(_nomeUsuario))
                throw new Exception("Informe o nome do usuário. ");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);

        }
        public void Alterar(Usuario _alterar, string _confirmacaoSenha)
        {
            ValidarDados(_alterar, _confirmacaoSenha);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_alterar);
        }
        public void Excluir(int _id)
        {

            UsuarioDAL usuarioDal = new UsuarioDAL();
            usuarioDal.Excluir(_id);
        }


        public List<Usuario> BuscarTodos()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }
        public Usuario BuscarPorId(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorId(_id);

        }
        public void AdicionarGrupo(int _idUsuario, int _idGrupoUsuario)
        {
            if (new UsuarioDAL().ExisteRelacionamento(_idUsuario, _idGrupoUsuario))
                return;
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.AdicionarGrupo(_idUsuario, _idGrupoUsuario);
        }

        public List<Usuario> BuscarPorNome(string _nome)
        {
            if (String.IsNullOrEmpty(_nome))
                throw new Exception("Informe o nome do usuário. ");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNome(_nome);
        }

        public void RemoverGrupoUsuario(int _idUsuario, int idGrupoUsuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            UsuarioDAL usuarioDal = new UsuarioDAL();
            usuarioDal.RemoverGrupoUsuario(_idUsuario, idGrupoUsuario);

        }
    }
}