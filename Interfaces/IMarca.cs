using AulaPOO_ProjetoDeProdutos.Classes;
namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface IMarca
    {
        void Cadastrar(Marca Marca);

        void Listar(Marca marca);

        void Deletar(Marca marca);


    }
}