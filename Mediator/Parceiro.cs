namespace Mediator
{
    public class Parceiro(IApp app) : IUsuario
    {
        public void EnviarMensagem(Mensagem mensagem)
        {
            app.EnviarMensagem(mensagem, this);
        }

        public void ReceberMensagem(Mensagem mensagem)
        {
            if(mensagem.TipoMensagem == EnumTipoMensagem.Solicitacao)
            {
                Console.WriteLine($"Mensagem recebida pelo parceiro:");
                Console.WriteLine($"***Viagem solicitada***\n");
            }
        }
    }
}