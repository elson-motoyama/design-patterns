namespace chain_of_responsability
{
    public class AnalistaSenior : Analista
    {
        private const int _nivel = 2;

        public AnalistaSenior(string nome) : base(nome) { }

        public void EncerrarChamado(Chamado chamado)
        {
            Console.WriteLine($"{Nome}(Analista Senior) encerrou o chamado(Complexidade {chamado.Complexidade})\n");
        }

        public void ResolverChamado(Chamado chamado)
        {
            Console.WriteLine($"{Nome}(Analista Senior) resolveu o chamado(Complexidade {chamado.Complexidade})\n");
        }

        public override void TratarChamado(Chamado chamado)
        {
            if (_nivel >= (int)chamado.Complexidade)
            {
                ResolverChamado(chamado);
                EncerrarChamado(chamado);
            }
            else
            {
                EncaminharChamado(chamado);
            }
        }

        public void EncaminharChamado(Chamado chamado)
        {
            Console.WriteLine($"{Nome}(Analista Senior) encaminhou o chamado(Complexidade {chamado.Complexidade}) para Departamento Técnico\n");
        }
    }   
}
