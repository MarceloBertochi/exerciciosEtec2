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


            // Gerar o número secreto
            int palpite, diferenca, senha = 100;
            senha = RandomNumberGenerator.GetInt32(1, 100);
            Console.WriteLine(senha);

            Console.WriteLine("A senha gerada é XXX");
            Console.WriteLine("Você consegue adinhar qual é a senha gerada?");
            Console.Write("Digite um número de 1 a 100, para darmos uma pista: ");
            palpite = Convert.ToInt32(Console.ReadLine());

            diferenca = palpite - senha;
            bool acertou = palpite == senha;

            Console.WriteLine(Math.Abs(diferenca));

            

                if (diferenca == 0)
                {
                    Console.WriteLine("uhuuuu você acertou");
                }

                else if (diferenca <= 10)
                {
                    Console.WriteLine("O valor é menor ou igual a 10."); 
                }

                 else
                { 
                    Console.WriteLine("O valor é maior ou igual a 30");

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
}


