namespace bridge
{
    /// <summary>
    /// Refined Abstraction
    /// </summary>
    public class Relatorio : RelatorioBase
    {
        public Relatorio(IGeraRelatorio geraRelatorio) : base(geraRelatorio) { }

        public override void GeraRelatorio()
        {
            Console.WriteLine("Geração do Relatório...");
            _geraRelatorio.GeraRelatorio();
        }
    }
}
