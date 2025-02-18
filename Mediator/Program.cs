namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IApp app = new App();
            Usuario parceiro = new Parceiro(app);
            Usuario cliente = new Cliente(app);

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
