using System;
using OrdemCarga.Core;

namespace OrdemCarga
{
    public class OrdemCargaTransferenciaFactory : IOrdemCargaFactory
    {
        public IOrdemCarga CriarOrdemCarga()
        {
            return new OrdemCargaTransferencia();
        }
    }
}
