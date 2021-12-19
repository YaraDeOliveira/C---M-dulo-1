using System;

namespace POO_Impacta
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();

            prod.Nome = "Mouse";
            prod.Preco = 100;
            Console.WriteLine($"Nome: {prod.Nome}");
            Console.WriteLine($"Preço: {prod.Preco:c}");

        }
    }
}
