using System.Security.Cryptography;

namespace QuenteFrio

{
    class Program

    {
        static void Main(string[] args)

        {
            LimparTela();
            MinhaAssinatura();
            PularLinha();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" -- Exercício Quente Frio -- ");
            ResetarCor();


            Console.WriteLine("Consegue advinhar um número entre 1 a 100?");

            int // tipo de dado para a variáve, do tipo inteiro
            palpite = 0, //declara variável palpite e inicializa com valor 0, esssa variável será usada para armazenar o palpite do jogador. 
            
            senha, // variável declarada para ser armazenada um número aleatório gerado pelo programa

            tentativa = 1; //variável declarada e dado o valor de 1, essa variável será usada para acompanhar o número de tentativas feitas pelo jogador. 

            bool acertou = false; // variável do tipo boleana chamada acertou com valor false, essa variável será usada para verificar se o jogador acertou a senha. 

            Console.Write($"Tente adivinhar a senha gerada -  {tentativa}a tentativa"); // mensagem solicitando para tentar adivinhar a senha gerada. 












            
            

            

               

                
            
            
            
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
}


