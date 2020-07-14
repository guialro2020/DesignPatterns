using DesignPatterns.Creational.Builder.Core;

namespace DesignPatterns.Creational.Builder
{
    public class Diretor
    {
        public IBuilder Builder { get; set; }

        public void ConstruirFerrari()
        {
            this.Builder.MarcaCarro = "Ferrari";
            this.Builder.BuildEtapaA();
            this.Builder.BuildEtapaB();
            this.Builder.BuildEtapaC();
        }

        public void ConstruirMasserati()
        {
            this.Builder.MarcaCarro = "Masserati";
            this.Builder.BuildEtapaA();
            this.Builder.BuildEtapaB();
            this.Builder.BuildEtapaC();
        }
    }
}
