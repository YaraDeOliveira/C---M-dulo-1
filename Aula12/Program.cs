using System;
using System.IO;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Environment
            string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "teste.txt";
            string path = Path.Combine(pasta, arquivo);

            //StreamWriter writer = new StreamWriter(path);
            //writer.WriteLine("Escrevendo no arquivo de texto...");
            //writer.WriteLine("Outra linha");
            //writer.Close();


            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string linha = reader.ReadLine();
                Console.WriteLine(linha);
            }
            


        }
    }
}
