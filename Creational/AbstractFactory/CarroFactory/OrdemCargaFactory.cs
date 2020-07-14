using AbstractFactory.OrdemCarga.Core;

namespace AbstractFactory.OrdemCargaFactory
{
    public abstract class OrdemCargaFactory
    {
        public static readonly OrdemCargaComumFactory ordemCargaComumFactory = new OrdemCargaComumFactory();
        public static readonly OrdemCargaParcialFactory ordemCargaParcialFactory = new OrdemCargaParcialFactory();
        public static readonly OrdemCargaTransferenciaFactory ordemCargaTransferenciaFactory = new OrdemCargaTransferenciaFactory();

        public static OrdemCargaFactory ObterFabrica(TipoOrdemCarga tipoOrdemCarga)
        {
            switch (tipoOrdemCarga)
            {
                case TipoOrdemCarga.Comum:
                    return ordemCargaComumFactory;
                case TipoOrdemCarga.Parcial:
                    return ordemCargaParcialFactory;
                case TipoOrdemCarga.Transferencia:
                    return ordemCargaTransferenciaFactory;
                default:
                    return new OrdemCargaComumFactory();
            }
        }

        public abstract OrdemCarga.Core.OrdemCarga CriarOrdemCarga();
    }
}
