using System;
using AulaPOO_ProjetoDeProdutos.Classes;

namespace AulaPOO_ProjetoDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {

            bool repetir1 = true;
            Usuario user = new Usuario();

            do
            {
                Console.Clear();
                Console.WriteLine($@"
            =============================
            |      Seja bem vindo!      |
            =============================
            | (1) Cadastrar             |
            =============================
            | (2) Logar                 |
            =============================
            | (0) Sair                  |
            =============================");


                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Qual o seu nome? ");
                        string name = Console.ReadLine();

                        Console.Write("Qual o seu email? ");
                        string email = Console.ReadLine();

                        Console.Write("Digite uma senha: ");
                        string password = Console.ReadLine();
                        

                        user.Cadastrar(new Usuario(name, email, password));
                        break;

                    case "2":

                        Console.Clear();
                        Console.Write("Digite seu email: ");
                        string g = Console.ReadLine();

                        Console.Write("Digite sua senha: ");
                        string p = Console.ReadLine();

                        user.validacao(g, p, 1);


                        break;

                    case "0":
                        repetir1 = false;
                        break;
                    default:
                        break;
                }
            } while (repetir1);
        }
    }
}
