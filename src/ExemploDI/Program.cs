using System;
using src.ExemploDI.Classes;

namespace ExemploDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var servico = new Servico(new Acolhimento());
            var resultado = servico.MensagemRecepcao("Paulo");

            Console.WriteLine(resultado);
        }
    }
}
