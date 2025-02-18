namespace Mediator
{
    public interface IUsuario
    {
        void EnviarMensagem(Mensagem mensagem);

        void ReceberMensagem(Mensagem mensagem);
    }
}
