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

            // NÃO CONSEGUI FAZER SOZINHO

            Console.WriteLine("--- Etanol ou Gasolina? ---\n");

Console.Write("Digite o preço do etanol (R$).....: ");
decimal etanol = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o preço da gasolina (R$)...: ");
decimal gasolina = Convert.ToDecimal(Console.ReadLine());

string recomendacao;

if (AbastecerComGasolina(etanol, gasolina))
{
    recomendacao = "Gasolina";
}
else
{
    recomendacao = "Etanol";
}

double razao = RazaoEtanolGasolina(etanol, gasolina) * 100;

Console.WriteLine($"\nO preço do etanol corresponde a {razao:N1}% do preço da gasolina.");
Console.WriteLine($"\nRecomendação: Abasteça com {recomendacao.ToUpper()}.");

double RazaoEtanolGasolina(decimal precoEtanol, decimal precoGasolina)
{
    return Convert.ToDouble(precoEtanol / precoGasolina);
}

bool AbastecerComGasolina(decimal precoEtanol, decimal precoGasolina)
{
    const double MinRazaoUsoGasolina = 0.73;
    return RazaoEtanolGasolina(precoEtanol, precoGasolina) >= MinRazaoUsoGasolina;
}

            
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

