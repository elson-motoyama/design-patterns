namespace Mediator
{
    public class App : IApp
    {
        private List<Usuario> usuarios = new();

        public void EnviarMensagem(Mensagem mensagem, Usuario usuario)
        {
            var destinatario = usuarios.Find(x => x.GetType() != usuario.GetType());

            if(destinatario != null)
                destinatario.ReceberMensagem(mensagem);
        }

        public void IncluirUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
    }
}
