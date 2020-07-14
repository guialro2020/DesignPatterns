using System;
using System.Collections.Generic;
using DesignPatterns.Creational.Builder.Core;

namespace DesignPatterns.Creational.Builder
{
    public class Ferrari : ICarro
    {
        private List<string> pecas = new List<string>();

        public void AdicionarPeca(string peca)
        {
            this.pecas.Add(peca);
        }

        public string ListarPecas()
        {
            return string.Join(";\r\n", this.pecas) + "\r\n";
        }
    }
}
