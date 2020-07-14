using System;
using OrdemCarga.Core;

namespace OrdemCarga
{
    public class OrdemCargaParcial : IOrdemCarga
    {
        public string LiberarOrdemCarga()
        {
            return "Liberado Parcialmente";
        }

        public string ObterTipoOrdemCarga()
        {
            return "Ordem de Carga Parcial";
        }
    }
}
