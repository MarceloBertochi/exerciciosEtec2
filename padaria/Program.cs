using System;

namespace Padaria

{
    class Program

    {
        static void Main(string[] args)

        {
            LimparTela();
            MinhaAssinatura();
            PularLinha();

            double
            grama,
            farinha,
            agua,
            fermento,
            sal;

            string input;

            Console.WriteLine("--- Padaria ---");

            Console.Write("Peso desejado de pão italiano (em gramas)...: ");

            do
            {
                input = Console.ReadLine();

                if (!double.TryParse(input, out grama))
                {
                    LimparTela();
                    Console.WriteLine("Entrada inválida, certifique-se de digitar um número válido");
                    Console.Write("Peso desejado de pão italiano (em gramas)...: ");

                }

                else
                {
                    Console.WriteLine($"O valor digitado em gramas é {grama}, seu pão terá {grama/1000} Kg");
                }

            }
            while (!double.TryParse(input, out grama));

            PularLinha();

            Console.WriteLine("ingredientes :");
            Console.WriteLine($"Farinha {(farinha = grama) / (1 + 0.7 + 0.4 + 0.02):n0} Gr");
            Console.WriteLine($"Água {agua = (grama * 70) / (1 + 0.7 + 0.4 + 0.02) / 100:n0} Ml");
            Console.WriteLine($"Fermento {fermento = (grama * 40) / (1 + 0.7 + 0.4 + 0.02) / 100:n0} Gr");
            Console.WriteLine($"Sal {sal = (grama * 2) / (1 + 0.7 + 0.4 + 0.02) / 100:n0} Gr");

            PularLinha();

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
