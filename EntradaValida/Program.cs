using System;

namespace EntradaValida

{
    class Program

    {
        static void Main(string[] args)

        {

            LimparTela();
            MinhaAssinatura();
            PularLinha();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //fiz sozinho
            Console.WriteLine(" --- Exercicio Entrada Válida --- ");
            PularLinha();
            ResetarCor();

            int valida;

            Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)...: ");
            valida = Convert.ToInt32(Console.ReadLine());
            PularLinha();
            LimparTela();

            switch (valida)
            {
                case 0:
                    Console.WriteLine($"número selecionado = {valida}, a operação será cancelada");
                    Console.WriteLine("Volte Sempre");
                    Console.WriteLine("digite qualquer tecla para sair");
                    Console.ReadKey();
                    break;

                case 1:
                    Console.WriteLine($"Número selecionado = {valida}");
                    Console.WriteLine("Volte Sempre");
                    break;

                case 2:
                    Console.WriteLine($"Número selecionado = {valida}");
                    Console.WriteLine("Volte Sempre");
                    break;

                case 3:
                    Console.WriteLine($"Número selecionado = {valida}");
                    Console.WriteLine("Volte Sempre");
                    break;

                case 4:
                    Console.WriteLine($"Número selecionado = {valida}");
                    Console.WriteLine("Volte Sempre");
                    break;

                case 5:
                    Console.WriteLine($"Número selecionado = {valida}");
                    Console.WriteLine("Volte Sempre");
                    break;

                case 6:
                    Console.WriteLine($"Número selecionado = {valida}");
                    Console.WriteLine("Volte Sempre");
                    break;

                case 7:
                    Console.WriteLine($"Número selecionado = {valida}");
                    Console.WriteLine("Volte Sempre");
                    break;

                case 8:
                    Console.WriteLine($"Número selecionado = {valida}");
                    Console.WriteLine("Volte Sempre");
                    break;

                case 9:
                    Console.WriteLine($"Número selecionado = {valida}");
                    Console.WriteLine("Volte Sempre");
                    break;

                default:
                    Console.WriteLine("Número Inválido, Operação cancelada");
                    Console.WriteLine("Volte Sempre");
                    return;
                    break;
            }
        }

        // minha assinatura começa aqui
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

        static void PularLinha()
        {
            Console.WriteLine();
        }

        static void LimparTela()
        {
            Console.Clear();
        }
    }
}
