using DesignPatterns.Creational.Builder.Core;

namespace DesignPatterns.Creational.Builder
{
    public class FactoryCarro : IFactoryCarro
    {
        public ICarro CriarCarro(string marca)
        {
            switch (marca?.ToLower())
            {
                case "ferrari":
                    return new Ferrari();
                case "masserati":
                    return new Masserati();
                default:
                    return new Ferrari();
            }
        }
    }
}
