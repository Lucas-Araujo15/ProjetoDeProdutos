using AulaPOO_ProjetoDeProdutos.Interfaces;
using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{

    public class Marca : IMarca
    {
        public int codigo{get; set;}
        public string NomeMarca{get; set;}
        public DateTime DataCadastro{get; set;}

        List<Marca> listaMarcas = new List<Marca>();

        public string Cadastrar(Marca marcaCadastrar)
        {
            listaMarcas.Add(marcaCadastrar);
            return "Marca Cadastrada";
        }

        public string Deletar(Marca marcaDeletar)
        {
            listaMarcas.Remove(marcaDeletar);
            return "Marca deletada";
        }

        public void Listar()
        {
            Console.WriteLine("A lista de marcas está aqui");
            foreach (Marca item in listaMarcas)
            {
                Console.WriteLine($"O seu código é {item.codigo}, O nome da sua marca é: {item.NomeMarca} e Data de cadastro: {item.DataCadastro}");
            }
    }
}
}
