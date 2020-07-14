namespace AbstractFactory.OrdemCargaFactory
{
    public class OrdemCargaComumFactory : OrdemCargaFactory
    {
        public override OrdemCarga.Core.OrdemCarga CriarOrdemCarga()
        {
            return new OrdemCarga.Core.OrdemCarga(OrdemCarga.Core.TipoOrdemCarga.Comum);
        }
    }
}
