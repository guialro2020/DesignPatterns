namespace AbstractFactory.OrdemCarga.Core
{
    public class OrdemCarga
    {
        public TipoOrdemCarga TipoOrdemCarga { get; set; }

        public OrdemCarga(TipoOrdemCarga tipoOrdemCarga)
        {
            this.TipoOrdemCarga = tipoOrdemCarga;
        }

        public override string ToString()
        {
            return this.TipoOrdemCarga.ToString();
        }
    }
}
