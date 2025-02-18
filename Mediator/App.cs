namespace Mediator
{
    public class App : IApp
    {
        private readonly List<IUsuario> usuarios = [];

        public void EnviarMensagem(Mensagem mensagem, IUsuario usuario)
        {
            var destinatario = usuarios.Find(x => x.GetType() != usuario.GetType());

            destinatario?.ReceberMensagem(mensagem);
        }

        public void IncluirUsuario(IUsuario usuario)
        {
            usuarios.Add(usuario);
        }
    }
}
