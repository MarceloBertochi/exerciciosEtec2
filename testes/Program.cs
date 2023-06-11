using System;

namespace ProgramaParaTeste

{
    class Program

    {
        static void Main(string[] args)
        {
         string nome = "Marcelo";

         int ComprimentoTexto = 10;

         char preenchimentoTexto = '*';

         Console.WriteLine($"{nome.PadRight(ComprimentoTexto, preenchimentoTexto )}");
         
        }


    }
}

