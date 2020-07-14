namespace AbstractFactory.OrdemCargaFactory
{
    public class OrdemCargaTransferenciaFactory : OrdemCargaFactory
    {
        public override OrdemCarga.Core.OrdemCarga CriarOrdemCarga()
        {
            return new OrdemCarga.Core.OrdemCarga(OrdemCarga.Core.TipoOrdemCarga.Transferencia);
        }
    }
}
