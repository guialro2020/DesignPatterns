namespace AbstractFactory.OrdemCargaFactory
{
    public class OrdemCargaParcialFactory : OrdemCargaFactory
    {
        public override OrdemCarga.Core.OrdemCarga CriarOrdemCarga()
        {
            return new OrdemCarga.Core.OrdemCarga(OrdemCarga.Core.TipoOrdemCarga.Parcial);
        }
    }
}
