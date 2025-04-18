namespace adapter
{
    public class Adapter : ITarget
    {
        public void Rotina()
        {
            var funcionalidadeAtualizada = new Adaptee();

            funcionalidadeAtualizada.RotinaAtualizada();
        }
    }
}
