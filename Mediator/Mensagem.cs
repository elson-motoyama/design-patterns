namespace Mediator
{
    public class Mensagem
    {
        public EnumTipoMensagem TipoMensagem { get; set; }

        public EnumRespostaSolicitacao RespostaSolicitacao { get; set; }
    }

    public enum EnumTipoMensagem
    {
        NaoDefinido = 0,
        Solicitacao = 1,       
        Resposta = 2
    }

    public enum EnumRespostaSolicitacao
    {
        NaoDefinido = 0,
        Aceita = 1,
        Rejeitada = 2
    }
}
