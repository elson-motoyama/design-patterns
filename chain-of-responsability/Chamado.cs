namespace chain_of_responsability
{
    public class Chamado
    {
        public EnumComplexidade Complexidade { get; }

        public Chamado(EnumComplexidade complexidade)
        {
            Complexidade = complexidade;
        }
    }

    public enum EnumComplexidade
    {
        Baixa = 0,
        Media = 1,
        Alta = 2,
        NaoDefinida = 3
    }
}
