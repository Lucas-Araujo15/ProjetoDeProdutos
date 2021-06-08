using AulaPOO_ProjetoDeProdutos.Interfaces;
using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Produto
    {
        public class Produtos : IProduto
    {
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataCadastroP { get; set; }
        public float Preco { get; set; }
        public Marca marca { get; set; }
         List<Produto> ListaProdutos = new List<Produto>();

         public string Cadastrar(Produto produto)
        {
            ListaProdutos.Add(produto);
            return "Produto cadastrado com sucesso!";
        }

        public List<Produto> Listar()
        {
            return ListaProdutos;
        }

        public string Deletar(Produto produto)
        {
            ListaProdutos.Remove(produto);
            return "Produto removido com sucesso!";
        }

            void IProduto.Cadastrar(Produto produto)
            {
                throw new NotImplementedException();
            }

            public void Listar(Produto produto)
            {
                throw new NotImplementedException();
            }

            void IProduto.Deletar(Produto produto)
            {
                throw new NotImplementedException();
            }
        }
}
}