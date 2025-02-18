namespace Mediator
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var app = new App();
            var parceiro = new Parceiro(app);
            var cliente = new Cliente(app);

            app.IncluirUsuario(parceiro);
            app.IncluirUsuario(cliente);

            var mensagemCliente = new Mensagem
            {
                TipoMensagem = EnumTipoMensagem.Solicitacao
            };

            cliente.EnviarMensagem(mensagemCliente);

            var mensagemParceiro = new Mensagem
            {
                TipoMensagem = EnumTipoMensagem.Resposta,
                RespostaSolicitacao = EnumRespostaSolicitacao.Aceita
            };

            parceiro.EnviarMensagem(mensagemParceiro);

            Console.Read();
        }
    }
}
