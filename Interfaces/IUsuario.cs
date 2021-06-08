using AulaPOO_ProjetoDeProdutos.Classes;
namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface IUsuario
    {
        void Cadastrar(Usuario usuario);
        void Deletar(Usuario usuario);
        void validacao(string k, string q);
    }
}