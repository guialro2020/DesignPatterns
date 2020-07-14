using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Builder.Core;
using System;

namespace DesignPatterns.Creational.BuilderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var diretor = new Diretor();
            IBuilder builder = new Builder.Builder();
            diretor.Builder = builder;

            diretor.ConstruirFerrari();
            Console.WriteLine("Diretor - Ferrari");
            Console.WriteLine(builder.GetResult().ListarPecas());

            diretor.ConstruirMasserati();
            Console.WriteLine("Diretor - Masserati");
            Console.WriteLine(builder.GetResult().ListarPecas());

            IBuilder builderComum = new Builder.Builder();
            builderComum.MarcaCarro = "ferrari";
            builderComum.BuildEtapaA();
            builderComum.BuildEtapaB();
            builderComum.BuildEtapaC();

            Console.WriteLine("Builder Comum - Masserati");
            Console.WriteLine(builderComum.GetResult().ListarPecas());

            Console.ReadKey();
        }
    }
}
