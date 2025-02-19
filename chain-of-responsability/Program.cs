namespace chain_of_responsability
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var chamado = new Chamado(EnumComplexidade.Alta);

            Analista n3 = new AnalistaSenior("Fulano");
            Analista n2 = new AnalistaPleno("Sicrano");
            Analista n1 = new AnalistaJunior("Beltrano");

            n1.DefinirProximoNivel(n2)
              .DefinirProximoNivel(n3);

            n1.TratarChamado(chamado);

            Console.Read();
        }
    }
}
