namespace composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pasta1 = new Pasta("Padrões estruturais");
            var arquivo1 = new Arquivo("Adapter.txt");
            var arquivo2 = new Arquivo("Bridge.txt");

            pasta1.Add(arquivo1);
            pasta1.Add(arquivo2);

            var pasta2 = new Pasta("Padrões comportamentais");
            var arquivo3 = new Arquivo("Chain of Responsibility.txt");
            var arquivo4 = new Arquivo("Command.txt");

            pasta2.Add(arquivo3);
            pasta2.Add(arquivo4);

            var pastaRaiz = new Pasta("Design Patterns");

            pastaRaiz.Add(pasta1);
            pastaRaiz.Add(pasta2);

            pastaRaiz.Imprimir(0);

            Console.Read();
        }
    }
}
