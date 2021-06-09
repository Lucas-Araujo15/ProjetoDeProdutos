using System;
using AulaPOO_ProjetoDeProdutos.Interfaces;
namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Login : ILogin
    {
        private bool Logado;


        public Login()
        {

        }

        public void Deslogar(Usuario user)
        {
            Logado = false;
            Console.WriteLine($"{user.Nome} saiu do sistema.");
        }

        public void Logar(Usuario user)
        {

            Marca marca1 = new Marca();
            Produto product = new Produto();
            Logado = true;
            Console.WriteLine($"{user.Nome} entrou no sistema.");

            do
            {
                Console.WriteLine($@"
            =================================
            | (1) Cadastrar marca           |    
            ---------------------------------
            | (2) Deletar marca             |       
            ---------------------------------
            | (3) Listar marcas             |    
            ---------------------------------

            =================================
            | (4) Cadastrar produto         |
            ---------------------------------
            | (5) Deletar produto           |
            ---------------------------------
            | (6) Listar produtos           |
            ---------------------------------

            =================================
            | (0) Deslogar                  |
            =================================
            ");

                string resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "4":

                        if (marca1.listaMarcas.Count > 0)
                        {
                            Console.Clear();

                            marca1.Listar();
                            Console.Write("Digite o código da marca do produto: ");
                            int cod = int.Parse(Console.ReadLine());

                            Marca escolha = marca1.listaMarcas.Find(item => item.codigo == cod);


                            Console.Write("Qual o nome do produto? ");
                            string prod = Console.ReadLine();

                            Console.Write($"Qual o preço de {prod}? ");
                            float preco = float.Parse(Console.ReadLine());

                            product.Cadastrar(new Produto(prod, preco, escolha, user));
                        }
                        else
                        {
                            Console.WriteLine("Não há marcas para cadastrar o produto");
                        }
                        break;

                    case "5":
                        if (product.ListaProdutos.Count > 0)
                        {
                            product.Listar();
                            Console.Write("Digite o código do produto que deseja deletar: ");
                            int cod = int.Parse(Console.ReadLine());

                            Produto escolha = product.ListaProdutos.Find(item => item.CodigoProduto == cod);

                            product.Deletar(escolha);
                        }
                        break;

                    case "6":
                        product.Listar();
                        break;

                    case "1":
                        Console.Write("Qual o nome da marca? ");
                        string marc = Console.ReadLine();

                        marca1.Cadastrar(new Marca(marc));
                        break;

                    case "2":
                        marca1.Listar();
                        Console.Write("Digite o código da marca que deseja deletar: ");
                        int cod1 = int.Parse(Console.ReadLine());
                        marca1.Deletar(marca1.listaMarcas.Find(item => item.codigo == cod1));
                        break;

                    case "3":
                        marca1.Listar();
                        break;
                    case "0":
                        Logado = false;
                        break;
                    default:
                        break;
                }
            } while (Logado);

        }
    }
}