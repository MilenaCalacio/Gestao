using DAL; 
using Models;


namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
                throw new Exception("O nome de usuário deve ter mais de três caracteres.");

            if (_usuario.NomeUsuario.Contains(" "))
                throw new Exception("O Nome de usuário não pode conter espaço");

           if (_usuario.Senha.Contains ("1234567"))
            throw new Exception("Não é permitido um número sequencial.");

            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
                throw new Exception(" A senha deve ter entre 7 e 11 caracteres.");

            // TODO: Validar se já existe um usuário com este nome.

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public Usuario Buscar (string _nomeUsuario)
        {
            return new Usuario();
        }
        public void Alterar (Usuario _usuario)
        {

        }
        public void Excluir (int _id)
        {
          
        }
    }
}