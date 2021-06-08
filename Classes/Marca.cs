using AulaPOO_ProjetoDeProdutos.Interfaces;
using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{

    public class Marca : IMarca
    {
        public int Codigo;

        public string NameMarca;

        public DateTime DataCadastro;


        public List<Marca> ListaMarcas = new List<Marca>();

        public string Cadastrar(Marca marca)
        {
            ListaMarcas.Add(marca);
            return "Marca cadastrada com sucesso!!";
        }

        public void Listar()
        {
            foreach (Marca item in ListaMarcas)
            {
                Console.WriteLine($@" 
                    {item.NameMarca}
                    {item.Codigo}
                    {item.DataCadastro}");
            }
        }

        public string Deletar(Marca marca)
        {
            ListaMarcas.Remove(marca);
            return "Marca removida com sucesso!!";
        }

    }
}
