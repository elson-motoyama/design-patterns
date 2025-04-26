namespace bridge
{
    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class GeraFormatoJson : IGeraRelatorio
    {
        public void GeraRelatorio() =>
            Console.WriteLine("Relatório gerado no formato Json");
    }
}