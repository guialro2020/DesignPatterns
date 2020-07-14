using AbstractFactory.OrdemCarga.Core;
using AbstractFactory.OrdemCargaFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbstractFactory.AbstractFactoryTest
{
    [TestClass]
    public class ValidarFabrica
    {
        [TestMethod]
        public void SeTipoOrdemCargaComumRetornoCorreto()
        {
            var factory = OrdemCargaFactory.OrdemCargaFactory.ObterFabrica(TipoOrdemCarga.Comum);

            var ordemCarga = factory.CriarOrdemCarga();

            Assert.AreEqual(ordemCarga.TipoOrdemCarga, TipoOrdemCarga.Comum);
            Assert.AreEqual(ordemCarga.ToString(), TipoOrdemCarga.Comum.ToString());
        }

        [TestMethod]
        public void SeTipoOrdemCargaParcialRetornoCorreto()
        {
            var factory = OrdemCargaFactory.OrdemCargaFactory.ObterFabrica(TipoOrdemCarga.Parcial);

            var ordemCarga = factory.CriarOrdemCarga();

            Assert.AreEqual(ordemCarga.TipoOrdemCarga, TipoOrdemCarga.Parcial);
            Assert.AreEqual(ordemCarga.ToString(), TipoOrdemCarga.Parcial.ToString());
        }

        [TestMethod]
        public void SeTipoOrdemCargaTransferenciaRetornoCorreto()
        {
            var factory = OrdemCargaFactory.OrdemCargaFactory.ObterFabrica(TipoOrdemCarga.Transferencia);

            var ordemCarga = factory.CriarOrdemCarga();

            Assert.AreEqual(ordemCarga.TipoOrdemCarga, TipoOrdemCarga.Transferencia);
            Assert.AreEqual(ordemCarga.ToString(), TipoOrdemCarga.Transferencia.ToString());
        }

        [TestMethod]
        public void SeTipoOrdemCargaTransferenciaRetornoIncorreto()
        {
            var factory = OrdemCargaFactory.OrdemCargaFactory.ObterFabrica(TipoOrdemCarga.Transferencia);

            var ordemCarga = factory.CriarOrdemCarga();

            Assert.AreNotEqual(ordemCarga.TipoOrdemCarga, TipoOrdemCarga.Parcial);
            Assert.AreNotEqual(ordemCarga.ToString(), TipoOrdemCarga.Comum.ToString());
        }

        [TestMethod]
        public void SeTipoOrdemCargaParcialRetornoParcialIncorreto()
        {
            var factory = OrdemCargaFactory.OrdemCargaFactory.ObterFabrica(TipoOrdemCarga.Parcial);

            var ordemCarga = factory.CriarOrdemCarga();

            Assert.AreNotEqual(ordemCarga.TipoOrdemCarga, TipoOrdemCarga.Transferencia);
            Assert.AreNotEqual(ordemCarga.ToString(), TipoOrdemCarga.Comum.ToString());
        }
    }
}
