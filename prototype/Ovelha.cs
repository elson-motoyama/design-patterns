using System.Text.Json;

namespace prototype
{
    public class Ovelha : ICloneable
    {
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }

        public object Clone()
        {
            var objetoSerializado = JsonSerializer.Serialize(this);

            return JsonSerializer.Deserialize<Ovelha>(objetoSerializado);
        }

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
    }
}
