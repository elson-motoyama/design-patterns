using System.Runtime.CompilerServices;

namespace prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ovelha = new Ovelha
            {
                Nome = "Belinda",
                Endereco = new Endereco
                {
                    Rua = "Rua A",
                    Numero = 1
                }
            };

            var clone = (Ovelha)ovelha.Clone();

            clone.Nome = "Dolly";
            clone.Endereco.Rua = "Rua B";
            clone.Endereco.Numero = 2;

            System.Console.WriteLine($"Ovelha {ovelha.Nome} \nEnd. {ovelha.Endereco.Rua}, {ovelha.Endereco.Numero}");
            System.Console.WriteLine("\n");
            System.Console.WriteLine($"Ovelha {clone.Nome} \nEnd. {clone.Endereco.Rua}, {clone.Endereco.Numero}");
            System.Console.Read();
        }
    }
}
