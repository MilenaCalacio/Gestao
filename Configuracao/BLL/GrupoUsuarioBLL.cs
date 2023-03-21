using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;


namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario grupoUsuario)
        {
            if (grupoUsuario.NomeGrupo.Length <= 3 || grupoUsuario.NomeGrupo.Length >= 50)
                throw new Exception("O nome deve ter mais de três caracteres. ");


            //TODO: Validar se já existe um usuário com nome existente.

            GrupoUsuarioDal grupoUsuarioDal = new GrupoUsuarioDal();
            grupoUsuarioDal.Inserir(grupoUsuario);
        }

        public void Alterar(GrupoUsuario _alterar)
        {
            if (_alterar.NomeGrupo.Length <= 3 || _alterar.NomeGrupo.Length >= 50)
                throw new Exception("O nome deve ter mais de três caracteres. ");


            //TODO: Validar se já existe um usuário com nome existente.

            GrupoUsuarioDal grupoUsuarioDal = new GrupoUsuarioDal();
            grupoUsuarioDal.Alterar(_alterar);
        }

        public void Excluir(int _id)
        {
            GrupoUsuarioDal grupoUsuarioDal = new GrupoUsuarioDal();
            grupoUsuarioDal.Excluir(_id);
        }

        public GrupoUsuario BuscarPorNomeGrupoUsuario(string _nomeGrupoUsuario)
        {
            if (String.IsNullOrEmpty(_nomeGrupoUsuario))
                throw new Exception("Informe um grupo válido. ");

            GrupoUsuarioDal grupoUsuarioDAL = new GrupoUsuarioDal();
            return grupoUsuarioDAL.BuscarPorNomeGrupoUsuario(_nomeGrupoUsuario);

        }

        public List<GrupoUsuario> BuscarTodos()
        {
            GrupoUsuarioDal grupoUsuarioDAL = new GrupoUsuarioDal();
            return grupoUsuarioDAL.BuscarTodos();
        }
        public GrupoUsuario BuscarPorId(int _id)
        {
            GrupoUsuarioDal grupoUsuarioDAL = new GrupoUsuarioDal();
            return grupoUsuarioDAL.BuscarPorId(_id);

        }


    }

}