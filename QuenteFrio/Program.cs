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
            int palpite, senha = 100;
            senha = RandomNumberGenerator.GetInt32(1,100);
            Console.WriteLine(senha);

            Console.WriteLine("A senha é XXX");
            Console.WriteLine("Você consegue adinhar qual é a senha gerada?");
            Console.WriteLine("Digite um número de 1 a 100, para darmos uma pista");
            palpite = Convert.ToInt32(Console.ReadLine());

            bool certo = palpite == senha;
           
            do    
            if (certo)
            {
                Console.WriteLine("Uhuuuuu você acertou a senha");
            }

            else
            {
                Console.WriteLine("voce errou , Tente mais uma vez");
            }

            while(certo);

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
