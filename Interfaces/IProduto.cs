using AulaPOO_ProjetoDeProdutos.Classes;
namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface IProduto
    {
        string Cadastrar(Produto produto);

        void Listar();

        string Deletar(Produto produto);
    }
}