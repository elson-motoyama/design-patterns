namespace composite
{
    /// <summary>
    /// Composite
    /// </summary>
    public class Pasta(string nome) : SistemaDeArquivos(nome)
    {
        private readonly List<SistemaDeArquivos> _filhos = [];

        public override void Imprimir(int nivel)
        {
            Console.WriteLine($"\n{new string('-', nivel * 2)}{_nome}");

            nivel++;

            foreach (var filho in _filhos)
            {
                filho.Imprimir(nivel);
            }
        }

        public void Add(SistemaDeArquivos filho)
        {
            _filhos.Add(filho);
        }

        public void Remove(SistemaDeArquivos filho)
        {
            _filhos.Remove(filho);
        }
    }
}
