using DesignPatterns.Creational.Builder.Core;

namespace DesignPatterns.Creational.Builder
{
    public class Builder : IBuilder
    {
        private ICarro carro;
        private IFactoryCarro factoryCarro = new FactoryCarro();

        public Builder()
        {
            carro = factoryCarro.CriarCarro(MarcaCarro);
        }

        public string MarcaCarro { get; set; }

        public void Reset()
        {
            this.carro = factoryCarro.CriarCarro(MarcaCarro);
        }

        public void BuildEtapaA()
        {
            this.carro.AdicionarPeca("Volante " + MarcaCarro);
        }

        public void BuildEtapaB()
        {
            this.carro.AdicionarPeca("Rodas " + MarcaCarro);
        }

        public void BuildEtapaC()
        {
            this.carro.AdicionarPeca("Pintura " + MarcaCarro);
        }

        public ICarro GetResult()
        {
            ICarro carro = this.carro;

            this.Reset();

            return carro;
        }
    }
}
