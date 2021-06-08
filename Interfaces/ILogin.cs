using AulaPOO_ProjetoDeProdutos.Classes;
namespace AulaPOO_ProjetoDeProdutos.Interfaces

{
    public interface ILogin
    {

        void Logar(Usuario user);
        void Deslogar(Usuario user);

    }
}