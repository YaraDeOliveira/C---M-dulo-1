using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            var impostos = new Impostos(0.10m);
            var impostos1 = new Impostos();
            decimal valorIss = impostos.CalcularISS("SP", 500);
            decimal valorIssIndiv = impostos.CalcularISS("SP", 500, true);

            Console.WriteLine($"O valor do imposto é {valorIss:c}");
            Console.WriteLine($"O valor do imposto Empresa Individual é {valorIssIndiv:c}");
            
        }
    }
}
