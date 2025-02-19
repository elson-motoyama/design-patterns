namespace chain_of_responsability
{
    public class AnalistaPleno : Analista
    {
        private const int _nivel = 1;

        public AnalistaPleno(string nome) : base(nome) { }

        public void EncerrarChamado(Chamado chamado)
        {
            Console.WriteLine($"{Nome}(Analista Pleno) encerrou o chamado(Complexidade {chamado.Complexidade})\n");
        }

        public void ResolverChamado(Chamado chamado)
        {
            Console.WriteLine($"{Nome}(Analista Pleno) resolveu o chamado(Complexidade {chamado.Complexidade})\n");
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
            Console.WriteLine($"{Nome}(Analista Pleno) encaminhou o chamado(Complexidade {chamado.Complexidade}) para {_suporteProximoNivel.Nome}\n");
            _suporteProximoNivel.TratarChamado(chamado);
        }
    }
}
