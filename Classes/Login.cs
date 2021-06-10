using System;
using System.Threading;
using AulaPOO_ProjetoDeProdutos.Interfaces;
namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Login : ILogin
    {
        public bool Logado;


        public Login()
        {

        }

        public void Deslogar(Usuario user)
        {
            Logado = false;
            Console.Clear();
            Console.WriteLine($"{user.Nome} saiu do sistema.");
            Thread.Sleep(2000);

        }

        public void Logar(Usuario user)
        {
            Marca marca1 = new Marca();
            Produto product = new Produto();
            Usuario user4 = new Usuario();
            Logado = true;
            Console.WriteLine($"{user.Nome} entrou no sistema.");
            Thread.Sleep(3000);

            do
            {
                Console.Clear();
                Console.WriteLine($@"

            .............Marca...............
            =================================
            | (1) Cadastrar marca           |    
            ---------------------------------
            | (2) Deletar marca             |       
            ---------------------------------
            | (3) Listar marcas             |    
            ---------------------------------

            ............Produtos.............
            =================================
            | (4) Cadastrar produto         |
            ---------------------------------
            | (5) Deletar produto           |
            ---------------------------------
            | (6) Listar produtos           |
            ---------------------------------

            ............Usuário..............
            =================================
            | (7) Informações do usuário    |
            =================================
            | (8) Alterar senha ou email    |
            =================================
            | (9) Deletar conta             |
            =================================

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

                            if (escolha != null)
                            {
                                Console.Write("Qual o nome do produto? ");
                                string prod = Console.ReadLine();

                                Console.Write($"Qual o preço de {prod}? ");
                                float preco = float.Parse(Console.ReadLine());

                                Console.Clear();
                                product.Cadastrar(new Produto(prod, preco, escolha, user));
                                Thread.Sleep(3000);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Não há nenhuma marca cadastrada com esse código");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Não há marcas para cadastrar o produto");
                            Thread.Sleep(2000);
                        }
                        break;

                    case "5":
                        if (product.ListaProdutos.Count > 0)
                        {
                            Console.Clear();
                            product.Listar();
                            Console.Write("Digite o código do produto que deseja deletar: ");
                            int cod = int.Parse(Console.ReadLine());

                            Produto escolha = product.ListaProdutos.Find(item => item.CodigoProduto == cod);
                            if (escolha != null)
                            {
                                product.Deletar(escolha);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Não há nenhum produto cadastrado com esse código");
                                Thread.Sleep(2000);
                            }

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Não há produtos cadastrados");
                            Thread.Sleep(2000);
                        }

                        break;

                    case "6":
                        if (product.ListaProdutos.Count > 0)
                        {
                            Console.Clear();
                            product.Listar();
                            Thread.Sleep(3000);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Não há produtos cadastrados");
                            Thread.Sleep(2000);
                        }
                        break;

                    case "1":
                        Console.Clear();
                        Console.Write("Qual o nome da marca? ");
                        string marc = Console.ReadLine();

                        Console.Clear();
                        marca1.Cadastrar(new Marca(marc));
                        Thread.Sleep(3000);
                        break;

                    case "2":
                        if (marca1.listaMarcas.Count > 0)
                        {
                            Console.Clear();
                            marca1.Listar();
                            Console.Write("Digite o código da marca que deseja deletar: ");
                            int cod1 = int.Parse(Console.ReadLine());
                            Marca delete = marca1.listaMarcas.Find(item => item.codigo == cod1);
                            if (delete != null)
                            {
                                marca1.Deletar(delete);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Não há nenhuma marca cadastrada com esse código");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Não há marcas cadastradas");
                            Thread.Sleep(2000);
                        }


                        break;

                    case "3":
                        if (marca1.listaMarcas.Count > 0)
                        {
                            Console.Clear();
                            marca1.Listar();
                            Thread.Sleep(3000);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Não há marcas cadastradas");
                            Thread.Sleep(2000);
                        }

                        break;
                    case "0":
                        Logado = false;
                        break;
                    case "7":
                        Console.Clear();
                        user.ListarProd(user);
                        break;
                    case "8":
                        user4.Alterar(user);
                        break;
                    case "9":
                        Console.Clear();
                        user4.ListarProd(user);
                        Console.WriteLine("\n");
                        Console.WriteLine("Tem certeza de que deseja deletar esta conta? (s/n)");
                        if (Console.ReadLine().ToLower() == "s")
                        {
                            user4.Deletar(user);
                            Logado = false;
                        }
                        else
                        {
                            Logado = true;
                        }

                        //user4.ListarProd(user);
                        //Console.WriteLine(user.Codigo);
                        //Console.Write("Digite o código do usuário: ");
                        //int cod5 = int.Parse(Console.ReadLine());
                        //Usuario test = user4.cadastros.Find(item => item.Codigo == cod5);
                        //Thread.Sleep(3000);

                        break;
                    default:
                        break;
                }
            } while (Logado);
        }
    }
}