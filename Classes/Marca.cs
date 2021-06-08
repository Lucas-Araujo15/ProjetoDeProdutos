using AulaPOO_ProjetoDeProdutos.Interfaces;
using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Marca
    {
        public class Marcas : IMarca
    {
        private int Codigo { get; set; }

        public string NameMarca { get;  set; }

        public DateTime DataCadastro { get; set; }


        List<Marca> ListaMarcas = new List<Marca>();

        public string Cadastrar(Marca marca)
        {
           ListaMarcas.Add(marca);
           return "Marca cadastrada com sucesso!!";
        }

        public List<Marca> Listar()
        {
            return ListaMarcas;
        }

        public string Deletar(Marca marca)
        {
            ListaMarcas.Remove(marca);
            return "Marca removida com sucesso!!";
        }

            public string Listar(Marca marca)
            {
                throw new NotImplementedException();
            }

            void IMarca.Cadastrar(Marca Marca)
            {
                throw new NotImplementedException();
            }

            void IMarca.Listar(Marca marca)
            {
                throw new NotImplementedException();
            }

            void IMarca.Deletar(Marca marca)
            {
                throw new NotImplementedException();
            }
        }
}
}