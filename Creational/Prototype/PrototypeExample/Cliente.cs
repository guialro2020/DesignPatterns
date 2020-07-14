using PrototypeExample.Core;

namespace PrototypeExample
{
    public class Cliente : ICliente
    {
        private string titulo;

        public string NomeCompleto { get; set; }

        public Cliente(string titulo)
        {
            this.titulo = titulo;
        }

        public string Display()
        {
            return $"{titulo}. {NomeCompleto}";
        }
    }
}
