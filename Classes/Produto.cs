using AulaPOO_ProjetoDeProdutos.Interfaces;
using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Produto : IProduto
    {

        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataCadastroP { get; set; }
        public float Preco { get; set; }
        public Marca marca { get; set; }
        public List<Produto> ListaProdutos = new List<Produto>();


        public Produto()
        {

        }
        public Produto(string _nome, float _preco, Marca mar)
        {

        }
        public string Cadastrar(Produto produto)
        {
            ListaProdutos.Add(produto);
            return "Produto cadastrado com sucesso!";
        }

        public void Listar()
        {
            foreach (Produto item in ListaProdutos)
            {
                Console.WriteLine($@" 
                    {item.NomeProduto}
                    {item.CodigoProduto}
                    {item.DataCadastroP}
                    {item.marca}
                    {item.Preco}");
            }
        }

        public string Deletar(Produto produto)
        {
            ListaProdutos.Remove(produto);
            return "Produto removido com sucesso!";
        }

        void IProduto.Cadastrar(Produto produto)
        {

        }

        public void Listar(Produto produto)
        {

        }

        void IProduto.Deletar(Produto produto)
        {

        }
    }
}
