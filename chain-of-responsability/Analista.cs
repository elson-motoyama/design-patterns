namespace chain_of_responsability
{
    public abstract class Analista
    {
        protected Analista? _suporteProximoNivel { get; set;}

        protected Analista(string nome)
        {
            Nome = nome;   
        }

        public string Nome { get; set; }

        public abstract void TratarChamado(Chamado chamado);

        public Analista DefinirProximoNivel(Analista suporteProximoNivel)
        {
            _suporteProximoNivel = suporteProximoNivel;

            return _suporteProximoNivel;
        }
    }
}
