using System;
using AulaPOO_ProjetoDeProdutos.Interfaces;
namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Login : ILogin
    {
        private bool Logado;
        public void Deslogar(Usuario user)
        {

        }

        public Login()
        {

        }

        public void Logar(Usuario user)
        {

            Marca marca1 = new Marca();
            Produto product = new Produto();


            Console.WriteLine($@"
            =================================
            | (1) Cadastrar produto         |    
            ---------------------------------
            | (2) Deletar produto           |       
            ---------------------------------
            | (3) Listar produtos           |    
            ---------------------------------

            =================================
            | (4) Cadastrar marca           |
            ---------------------------------
            | (5) Deletar marca             |
            ---------------------------------
            | (6) Listar marca              |
            ---------------------------------
            ");

            string resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":

                    if (marca1.ListaMarcas.Count > 0)
                    {
                        Console.Clear();

                        marca1.Listar();
                        Console.Write("Digite o código da marca do produto: ");
                        int cod = int.Parse(Console.ReadLine());

                        Marca escolha = marca1.ListaMarcas.Find(item => item.Codigo == cod);


                        Console.Write("Qual o nome do produto? ");
                        string prod = Console.ReadLine();

                        Console.Write($"Qual o preço de {prod}? ");
                        float preco = float.Parse(Console.ReadLine());

                        product.Cadastrar(new Produto(prod, preco, escolha));
                    }
                    else
                    {
                        Console.WriteLine("Não há marcas para cadastrar o produto");
                    }
                    break;

                case "2":
                    if (product.ListaProdutos.Count > 0)
                    {
                        product.Listar();
                        Console.Write("Digite o código do produto que deseja deletar: ");
                        int cod = int.Parse(Console.ReadLine());

                        Produto escolha = product.ListaProdutos.Find(item => item.CodigoProduto == cod);

                        product.Deletar(escolha);
                    }
                    break;

                case "3":
                    product.Listar();
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                default:
                    break;
            }
        }
    }
}