namespace bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGeraRelatorio formatoRelatorio = new GeraFormatoJson();
            Relatorio relatorio = new(formatoRelatorio);

            relatorio.GeraRelatorio();

            Console.Read();
        }
    }
}
