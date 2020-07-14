using System;
using OrdemCarga.Core;

namespace OrdemCarga
{
    public class OrdemCargaParcialFactory : IOrdemCargaFactory
    {
        public IOrdemCarga CriarOrdemCarga()
        {
            return new OrdemCargaParcial();
        }
    }
}
