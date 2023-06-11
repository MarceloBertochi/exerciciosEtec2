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


Console.WriteLine("--- Padaria ---");
Console.Write("Peso desejado de pão italiano (em gramas)...: ");
grama = Convert.ToDouble(Console.ReadLine());
LinhaAmarela();

Console.WriteLine("ingredientes :");
Console.WriteLine($"Farinha {Convert.ToDecimal((farinha = grama)/(1+0.7+0.4+0.02))} gr");
Console.WriteLine($"Água {Convert.ToDecimal( agua = (grama*70)/(1+0.7+0.4+0.02)/100)} gr");
Console.WriteLine($"Fermento {fermento = (grama*40)/(1+0.7+0.4+0.02)/100} gr");
Console.WriteLine($"Água {sal = (grama*2)/(1+0.7+0.4+0.02)/100} gr");





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
