using System;
using AulaPOO_ProjetoDeProdutos.Classes;
using System.Threading;
namespace AulaPOO_ProjetoDeProdutos
{
    class Program
    {
        static Usuario user = new Usuario();
        static void Main(string[] args)
        {

            bool repetir1 = true;


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
            =============================

            =============================
            | (3) Deletar conta         |
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
                    case "3":
                        if (user.cadastros.Count > 0)
                        {
                            Console.Clear();
                            foreach (Usuario item in user.cadastros)
                            {
                                Console.WriteLine($@" 
                ============================================
                |Nome: {item.Nome}
                ============================================
                |Código: {item.Codigo}
                ============================================
                |Email: {item.Email}
                ============================================
                |Data de cadastro: {item.DataCadastro}
                ============================================
                ");
                                Console.WriteLine("\n");
                            }
                            Console.Write("Digite o código da conta que deseja deletar: ");
                            int cod = int.Parse(Console.ReadLine());
                            Console.Clear();

                            Console.Write("Digite seu email: ");
                            string o = Console.ReadLine();

                            Console.Write("Digite sua senha: ");
                            string t = Console.ReadLine();

                            if (user.cadastros.Find(item => item.Codigo == cod).Email == o && user.cadastros.Find(item => item.Codigo == cod).Senha == t)
                            {
                                Console.Clear();
                                user.Deletar(user.cadastros.Find(item => item.Codigo == cod));
                                Console.WriteLine("Conta deletada com sucesso!");
                                Thread.Sleep(3000);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Senha e/ou email incorretos. Tente novamente");
                                Thread.Sleep(3000);
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Nenhuma conta foi cadastrada");
                            Thread.Sleep(3000);
                        }

                        break;
                    default:
                        break;
                }
            } while (repetir1);
        }
    }
}
