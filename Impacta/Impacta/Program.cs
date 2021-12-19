using System;
using System.Collections.Generic;

namespace Impacta
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dataexemplo = new DateTime(2050, 12, 31);
            //Console.WriteLine($"Com d minusculo: {dataexemplo:d}");
            //Console.WriteLine($"Com D maiusculo:{dataexemplo:D}");

            //decimal dinheiro = Convert.ToDecimal(1000.56);
            //Console.WriteLine($"{dinheiro:c}");

            int x = 10;
            int y = 3;
            double soma;
           
            soma = x + y;
            Console.WriteLine(soma);


            //Lista
            List<string> lista = new List<string>();
            lista.Add("São Paulo");
            lista.Add("Rio de Janeiro");
            lista.Add("Teste");

            List<int> lista2 = new List<int>();
            lista2.Add(10);
            lista2.Add(3);

            foreach (string c in lista)
            {
                Console.WriteLine(c);
            }

            foreach (int n in lista2){
                Console.WriteLine(n);
            }

            Console.WriteLine();


            // Fila
            Queue<string> Proc = new Queue<string>();
            Proc.Enqueue("Processo 1");
            Proc.Enqueue("Processo 2");
            Proc.Enqueue("Processo 3");

            while (Proc.Count > 0)
            {
                string item = Proc.Dequeue();
                Console.WriteLine(item);
            }


            // Pilha
            Stack<string> Processos = new Stack<string>();
            Processos.Push("Processo 1");
            Processos.Push("Processo 2");

            while (Processos.Count > 0)
            {
                string item = Processos.Pop();
                Console.WriteLine(item);
            }

            // Dicionario

            Dictionary<string, string> dados = new Dictionary<string, string>();

            dados.Add("Nome", "José da Silva");
            dados.Add("RG", "23.234.134");
            dados.Add("Telefone", "(11) 5555-2323");

            Console.WriteLine(dados["Nome"]);
            Console.WriteLine(dados["RG"]);
            Console.WriteLine(dados["Telefone"]);

            Console.ReadLine();
        }
    }
}
