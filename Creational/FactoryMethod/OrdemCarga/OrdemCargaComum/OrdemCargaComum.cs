using System;
using OrdemCarga.Core;

namespace OrdemCarga
{
    public class OrdemCargaComum : IOrdemCarga
    {
        public string LiberarOrdemCarga()
        {
            return "Liberado por completo";
        }

        public string ObterTipoOrdemCarga()
        {
            return "Ordem de Carga Comum";
        }
    }
}
