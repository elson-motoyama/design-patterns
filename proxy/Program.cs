namespace proxy
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy;

            Requisicao requisicaoMobile = new Requisicao
            {
                Origem = EnumOrigem.Mobile
            };

            Requisicao requisicaoWeb = new Requisicao
            {
                Origem = EnumOrigem.Web
            };

            proxy = new Proxy(requisicaoWeb);
            proxy.Enviar();

            proxy = new Proxy(requisicaoMobile);
            proxy.Enviar();

            Console.Read();
        }
    }
}
