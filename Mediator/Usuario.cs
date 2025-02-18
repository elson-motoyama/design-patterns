namespace Mediator
{
    public abstract class Usuario
    {
        public abstract void EnviarMensagem(Mensagem mensagem);

        public abstract void ReceberMensagem(Mensagem mensagem);
    }
}
