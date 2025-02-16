using System.Net;

namespace proxy
{
    public class Requisicao : IRequisicao
    {
        public HttpStatusCode Status { get; set; }
        public DateTime? DataHoraResposta { get; set; }
        public EnumOrigem Origem { get; set; }

        public void Enviar()
        {
            Console.WriteLine("***Requisição enviada com sucesso***");
            this.Status = System.Net.HttpStatusCode.OK;
            this.DataHoraResposta = DateTime.Now;
        }
    }

    public enum EnumOrigem
    {
        Web = 0,
        Mobile = 1
    }
}
