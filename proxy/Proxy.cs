using System.Net;

namespace proxy
{
    public class Proxy(Requisicao requisicao) : IRequisicao
    {
        public void Enviar()
        {
            RotinaPreEnvio();
            
            if(requisicao.Status != HttpStatusCode.Forbidden)
                requisicao.Enviar();
            else
                Console.WriteLine($"***Origem proibida***");

            RotinaPosEnvio();
        }

        private void RotinaPreEnvio()
        {
            if (requisicao.Origem == EnumOrigem.Mobile)
                requisicao.Status = System.Net.HttpStatusCode.Forbidden;
        }

        private void RotinaPosEnvio()
        {
            if (requisicao.Status == HttpStatusCode.Forbidden)
            {
                Console.WriteLine($"Origem: {requisicao.Origem}, Status: {(int)requisicao.Status} - {requisicao.Status}\n");
            }
            else
            {                
                Console.WriteLine($"Origem: {requisicao.Origem}, Status: {(int)requisicao.Status} - {requisicao.Status}, Resposta: {requisicao.DataHoraResposta}\n");
            }
        }
    }
}
