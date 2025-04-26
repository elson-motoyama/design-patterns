namespace bridge
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class RelatorioBase 
    {
        protected IGeraRelatorio _geraRelatorio;

        protected RelatorioBase(IGeraRelatorio geraRelatorio) =>
            _geraRelatorio = geraRelatorio;

        public abstract void GeraRelatorio();
    }
}
