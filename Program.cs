using System;
using AulaPOO_ProjetoDeProdutos.Classes;

namespace AulaPOO_ProjetoDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();

            Console.Write("Qual o seu nome? ");
            string name = Console.ReadLine();

            Console.Write("Qual o seu email? ");
            string email = Console.ReadLine();

            Console.Write("Digite uma senha: ");
            string password = Console.ReadLine();

            user.Cadastrar(new Usuario(name, email, password));

            Console.Write("Fazendo login...");

            Console.Write("Digite seu email: ");
            string e = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string s = Console.ReadLine();

            user.validacao(e, s);
        }
    }
}
