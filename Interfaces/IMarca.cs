using AulaPOO_ProjetoDeProdutos.Classes;
using System.Collections.Generic;
namespace AulaPOO_ProjetoDeProdutos.Interfaces

{
    public interface IMarca
    {
        string Cadastrar(Marca Marca);

        void Listar();

        string Deletar(Marca marca);


    }
}