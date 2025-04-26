namespace bridge
{
    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class GeraFormatoXml : IGeraRelatorio
    {
        public void GeraRelatorio() =>
            Console.WriteLine("Relatório gerado no formato Xml");
    }
}