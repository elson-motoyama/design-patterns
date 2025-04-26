namespace bridge
{
    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class GeraFormatoCsv : IGeraRelatorio
    {
        public void GeraRelatorio() =>
            Console.WriteLine("Relatório gerado no formato Csv");
    }
}