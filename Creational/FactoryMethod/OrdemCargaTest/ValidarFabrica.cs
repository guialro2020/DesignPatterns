using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdemCarga;
using OrdemCarga.Core;

namespace OrdemCargaTest
{
    [TestClass]
    public class ValidarFabrica
    {
        private IOrdemCargaFactory factory;

        [TestMethod]
        public void SeTipoOrdemCargaComumRetornoCorreto()
        {
            factory = new OrdemCargaComumFactory();

            var ordemCarga = factory.CriarOrdemCarga();
            
            Assert.AreEqual(ordemCarga.ObterTipoOrdemCarga(), "Ordem de Carga Comum");
            Assert.AreEqual(ordemCarga.LiberarOrdemCarga(), "Liberado por completo");
        }

        [TestMethod]
        public void SeTipoOrdemCargaParcialRetornoCorreto()
        {
            factory = new OrdemCargaParcialFactory();

            var ordemCarga = factory.CriarOrdemCarga();

            Assert.AreEqual(ordemCarga.ObterTipoOrdemCarga(), "Ordem de Carga Parcial");
            Assert.AreEqual(ordemCarga.LiberarOrdemCarga(), "Liberado Parcialmente");
        }

        [TestMethod]
        public void SeTipoOrdemCargaTransferenciaRetornoCorreto()
        {
            factory = new OrdemCargaTransferenciaFactory();

            var ordemCarga = factory.CriarOrdemCarga();

            Assert.AreEqual(ordemCarga.ObterTipoOrdemCarga(), "Ordem de Carga de Transferência");
            Assert.AreEqual(ordemCarga.LiberarOrdemCarga(), "Liberado para Transferência");
        }
    }
}
