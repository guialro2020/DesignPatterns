using DesignPatterns.Creational.Builder.Core;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Builder
{
    public class Masserati : ICarro
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
