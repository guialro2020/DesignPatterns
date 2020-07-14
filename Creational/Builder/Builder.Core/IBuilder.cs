namespace DesignPatterns.Creational.Builder.Core
{
    public interface IBuilder
    {
        string MarcaCarro { get; set; }
        void Reset();
        void BuildEtapaA();
        void BuildEtapaB();
        void BuildEtapaC();
        ICarro GetResult();
    }
}
