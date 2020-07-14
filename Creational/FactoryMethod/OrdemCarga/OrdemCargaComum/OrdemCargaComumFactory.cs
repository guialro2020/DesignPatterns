using OrdemCarga.Core;

namespace OrdemCarga
{
    public class OrdemCargaComumFactory : IOrdemCargaFactory
    {
        public IOrdemCarga CriarOrdemCarga()
        {
            return new OrdemCargaComum();
        }
    }
}
