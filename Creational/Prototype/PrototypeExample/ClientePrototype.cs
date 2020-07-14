using Newtonsoft.Json;

namespace PrototypeExample
{
    public class ClientePrototype<T> where T: class
    {
        private T cliente;

        public ClientePrototype(T cliente)
        {
            this.cliente = cliente;
        }

        public T Clone()
        {
            var clienteSerializado = JsonConvert.SerializeObject(this);
            var cliente = JsonConvert.DeserializeObject<T>(clienteSerializado);

            return cliente;
        }
    }
}
