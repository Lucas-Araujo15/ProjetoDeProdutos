using AulaPOO_ProjetoDeProdutos.Classes;
namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface IProduto
    {
        void Cadastrar(Produto produto);

        void Listar(Produto produto);

        void Deletar(Produto produto);
    }
}