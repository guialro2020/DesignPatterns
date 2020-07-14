using System;
using OrdemCarga.Core;

namespace OrdemCarga
{
    public class OrdemCargaTransferencia : IOrdemCarga
    {
        public string LiberarOrdemCarga()
        {
            return "Liberado para Transferência";
        }

        public string ObterTipoOrdemCarga()
        {
            return "Ordem de Carga de Transferência";
        }
    }
}
