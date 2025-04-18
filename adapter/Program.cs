namespace adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITarget funcionalidade = new Adapter();

            funcionalidade.Rotina();

            Console.Read();
        }
    }
}
