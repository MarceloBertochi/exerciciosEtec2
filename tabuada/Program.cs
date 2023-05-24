using System;

namespace Tabuada

{
    class Program

    {
        static void Main(string[] args)

        {
            LimparTela();
            MinhaAssinatura();
            PularLinha();

            Console.WriteLine("-- Exercício de Tabuada --");
            PularLinha();
            

            int tabuada, contador = 0;

            Console.Write("Digite o número da tabuada..: ");
            tabuada = Convert.ToInt32(Console.ReadLine());
            PularLinha();

            Console.WriteLine($"Você escolheu a tabuada do {tabuada}");

            do
            {
                Console.Write($" {tabuada} x {contador} = ");
                Console.WriteLine(tabuada * contador);
                contador = contador + 1;
                
            }
            while(contador <=10);          
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

