using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonExample.Test
{
    [TestClass]
    public class DatabaseTest
    {
        [TestMethod]
        public void SingletonOk()
        {
            var random = new Random();
            var listaRetorno = new List<string>();

            Task[] tasks = new Task[10];

            for (int i = 0; i < 10; i++)
            {
                var task = Task.Factory.StartNew(() =>
                {
                    var dataBase = Database.GetInstance(random.Next().ToString());
                    listaRetorno.Add(dataBase.Query("teste"));
                });

                tasks[i] = task;
            }

            for (int i = 0; i < 10; i++)
            {
                Task.WaitAll(tasks);
            }

            var todosIguais = listaRetorno.Distinct().Count();

            Assert.AreEqual(1, todosIguais);
        }
    }
}
