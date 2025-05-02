namespace composite
{
    /// <summary>
    /// Component
    /// </summary>
    public abstract class SistemaDeArquivos(string nome)
    {
        protected string _nome = nome;

        public abstract void Imprimir(int nivel);
    }

}
