namespace composite
{
    /// <summary>
    /// Leaf
    /// </summary>
    public class Arquivo(string nome) : SistemaDeArquivos(nome)
    {
        public override void Imprimir(int nivel) =>
            Console.WriteLine($"{new string('-', nivel * 2)}{_nome}");
    }
}
