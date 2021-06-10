using System.Collections.Generic;
using System;
using System.Threading;
using AulaPOO_ProjetoDeProdutos.Interfaces;
namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Usuario : IUsuario
    {
        Login login = new Login();

        public List<Usuario> cadastros = new List<Usuario>();
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public Usuario()
        {

        }
        public Usuario(string _nome, string _email, string _senha)
        {
            this.Nome = _nome;
            this.Email = _email;
            this.Senha = _senha;

            Random cod = new Random();
            this.Codigo = cod.Next(0, 9999);
            this.DataCadastro = DateTime.Now;
        }
        public void Cadastrar(Usuario usuario)
        {
            cadastros.Add(usuario);

        }
        public void Deletar(Usuario usuarioo)
        {
            cadastros.Remove(usuarioo);

        }

        public void validacao(string k, string q, int a)
        {

            if (cadastros.Find(item => item.Email == k) != null)
            {
                if (cadastros.Find(item => item.Email == k).Senha == q)
                {
                    login.Logar(cadastros.Find(item => item.Email == k));


                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Senha ou usuário incorreto. Tente novamente");
                    Thread.Sleep(2000);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Senha ou usuário incorreto. Tente novamente");
                Thread.Sleep(2000);
            }
        }

        public void ListarProd(Usuario user2)
        {
            Console.WriteLine($@" 
                ============================================
                |Nome: {user2.Nome}
                ============================================
                |Código: {user2.Codigo}
                ============================================
                |Email: {user2.Email}
                ============================================
                |Data de cadastro: {user2.DataCadastro}
                ============================================
                ");
            Thread.Sleep(5000);
        }

        public void Alterar(Usuario user3)
        {

            Console.Clear();

            Console.Write("Digite seu email: ");
            string g = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string p = Console.ReadLine();

            if (g == user3.Email && p == user3.Senha)
            {
                Console.Clear();
                Console.WriteLine($@"
                ============================
                |    Selecione uma opção   |
                ============================
                | (1) Alterar Email        |
                ============================
                | (2) Alterar senha        |
                ============================");

                string alterando = Console.ReadLine();
                if (alterando == "1")
                {
                    Console.Clear();
                    login.Logado = true;
                    Console.Write("Digite um novo email: ");
                    string u = Console.ReadLine();

                    user3.Email = u;
                }
                else
                {
                    Console.Clear();
                    login.Logado = true;
                    Console.Write("Digite uma nova senha: ");
                    string l = Console.ReadLine();
                    user3.Senha = l;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Senha ou usuário incorreto. Tente novamente");
                Thread.Sleep(2000);
            }
        }
    }
}