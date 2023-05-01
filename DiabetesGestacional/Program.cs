using System;

namespace DiabetesGestacional

{
    class Program

    {
        static void Main(string[] args)

        {
            int
            valorGlicemia;


            Console.Clear();

            Console.WriteLine("--- Diabetes Gestacional ---\n");

            Console.Write("Digite o valor de glicemia (em mg/dL)..: ");
            valorGlicemia = Convert.ToInt32(Console.ReadLine());

            if (valorGlicemia < 92)

            {
                Console.WriteLine("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose\n");
            }

            else if (valorGlicemia >= 92 && valorGlicemia < 126)
            {
                Console.WriteLine("Compatível com Diabetes Gestacional\n");
            }

            else if (valorGlicemia >= 126)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Beep(); Console.Beep(); Console.Beep();
                Console.WriteLine("Diabetes Mellitus na Gravidez\n");
                Console.ResetColor();
            }
        }
    }
}

