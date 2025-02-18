namespace Mediator
{
    public class Cliente(IApp app) : Usuario
    {
        public override void EnviarMensagem(Mensagem mensagem)
        {
            app.EnviarMensagem(mensagem, this);
        }

        public override void ReceberMensagem(Mensagem mensagem)
        {
            if (mensagem.TipoMensagem == EnumTipoMensagem.Resposta)
            {
               Console.WriteLine($"Mensagem recebida pelo cliente:");
               Console.WriteLine($"***Viagem {mensagem.RespostaSolicitacao}***\n");
            }
        }
    }
}