namespace Mediator
{
    public interface IApp
    {
        void EnviarMensagem(Mensagem mensagem, Usuario usuario);

        void IncluirUsuario(Usuario usuario);
    }
}
