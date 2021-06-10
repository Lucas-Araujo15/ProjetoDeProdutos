using AulaPOO_ProjetoDeProdutos.Classes;
namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface IUsuario
    {
        void Cadastrar(Usuario usuario, int d);
        void Deletar(Usuario usuario, int h);
        void validacao(string k, string q, int b);

        void ListarProd(Usuario user1);

        void Alterar(Usuario user3);
    }
}