using System.Collections.Generic;
using System;
using AulaPOO_ProjetoDeProdutos.Interfaces;
using AulaPOO_ProjetoDeProdutos.Classes;
namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Usuario : IUsuario
    {
        Login login = new Login();
        public List<Usuario> cadastros = new List<Usuario>();
        private int Codigo;
        private string Nome;
        private string Email;
        private string Senha;
        private DateTime DataCadastro;

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
        public void Deletar(Usuario usuario)
        {
            cadastros.Remove(usuario);
        }

        public void validacao(string k, string q)
        {
            Usuario logando = cadastros.Find(item => cadastros.Find(item => item.Email == k).Senha == q);

            if (logando != null)
            {
                login.Logar(logando);
            }
            else
            {
                Console.WriteLine("Senha ou usuário incorreto. Tente novamente");
            }
        }
    }
}