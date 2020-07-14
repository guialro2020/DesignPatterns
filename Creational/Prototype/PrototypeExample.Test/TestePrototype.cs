using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrototypeExample;
using PrototypeExample.Core;

namespace PrototypeExample.Test
{
    [TestClass]
    public class TestePrototype
    {
        [TestMethod]
        public void CopiaExata()
        {
            var cliente = new Cliente("Dr");
            cliente.NomeCompleto = "Guilherme Alves Rodrigues";

            var prototype = new ClientePrototype<Cliente>(cliente);
            var clone = prototype.Clone();

            clone.NomeCompleto = "José";

            Assert.AreNotEqual(cliente.Display(), clone.Display());
        }

        [TestMethod]
        public void CopiaErrada()
        {
            var cliente = new Cliente("Dr");
            cliente.NomeCompleto = "Guilherme Alves Rodrigues";

            var clone = cliente;

            clone.NomeCompleto = "José";

            Assert.AreEqual(cliente.Display(), clone.Display());
        }
    }
}
