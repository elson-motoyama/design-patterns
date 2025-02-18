namespace Mediator
{
    public interface IApp
    {
        void EnviarMensagem(Mensagem mensagem, IUsuario usuario);

        void IncluirUsuario(IUsuario usuario);
    }
}
