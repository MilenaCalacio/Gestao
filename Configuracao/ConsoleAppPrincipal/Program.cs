using BLL;
using Models;


internal class Program
{

    private static void Main(string[] args)
    {
        int questao;

        try
        {

            string opcao;
            Usuario usuario = new Usuario();
            UsuarioBLL usuarioBLL = new UsuarioBLL();


            do
            {

                Console.WriteLine("informe o seu nome completo: ");
                usuario.Nome = Console.ReadLine();


                Console.WriteLine("informe o seu nome de usuario ");
                usuario.NomeUsuario = Console.ReadLine();


                Console.WriteLine("O usuário estará ativo (S) ou (N)");
                usuario.Ativo = Console.ReadLine().ToUpper() == "S";

                Console.WriteLine("informe o seu e-mail");
                usuario.Email = Console.ReadLine();


                Console.WriteLine("informe seu CPF");
                usuario.CPF = Console.ReadLine();

                Console.WriteLine("crie uma senha com no minimo sete digitos");
                usuario.Senha = Console.ReadLine();

                usuarioBLL.Inserir(usuario);

                Console.WriteLine("Deseja fazer cadastro? [S] SIM [N] NAO");
                questao = Convert.ToInt32(Console.ReadLine());
            } while (questao == 1);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }

    }
}
