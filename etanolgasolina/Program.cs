using System;

namespace EtanolGasolina

{
    class Program

    {
        static void Main(string[] args)

        {
            //etano, gasolina

            LimparTela();
            MinhaAssinatura();
            ResetarCor();
            PularLinha();

            Console.WriteLine("Exercício Alcool Ou Gasolina");
            LinhaAmarela();
            PularLinha();

            Console.WriteLine("--- Etanol ou Gasolina? ---");
            PularLinha();

            Console.Write("Digite o preço do etanol (R$).......:");
            Console.ReadLine();
            Console.Write("Digite o preço da gosolina (R$).....:");
            Console.ReadLine();
            PularLinha();

            Console.WriteLine("O preço do etanol corresponde a ?? % do preço da gasolina.");
            PularLinha();

            Console.WriteLine("Recomendação: Abasteça com ETANOL.");
        }






        static void MinhaAssinatura()
        {
            LinhaAmarela();
            BarraAmarelaInicio();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" Trabalho para Nota do Aluno ");
            BarraAmarelaFinal();
            BarraAmarelaInicio();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" Marcelo Camara Bertochi ");
            BarraAmarelaFinal2();
            BarraAmarelaInicio();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" Curso Informática I - Noite ");
            BarraAmarelaFinal();
            LinhaAmarela();
        }

        static void LinhaAmarela()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("-------------------------------\n");
            Console.ResetColor();
        }

        static void BarraAmarelaInicio()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("|");
            Console.ResetColor();
        }
        static void BarraAmarelaFinal()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("|\n");
            Console.ResetColor();
        }

        static void BarraAmarelaFinal2()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("|\n".PadLeft(6, ' '));
            Console.ResetColor();
        }
        static void ResetarCor()
        {
            Console.ResetColor();
        }

        static void LimparTela()
        {
            Console.Clear();
        }

        static void PularLinha()
        {
            Console.WriteLine();
        }


    }


}
