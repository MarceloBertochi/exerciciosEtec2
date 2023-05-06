using System;

namespace LuzDeAdvertencia

{
    class Program

    {
        static void Main(string[] args)

        {
            Console.Clear();

            Console.WriteLine("--- Luz De Advertência ---\n");

            string 
            t, // Temperatura
            p, // Pressão
            r; // Rotação

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("--- Simulador de Luz de Advertência ---\n");
            Console.ResetColor();

            Console.WriteLine("[A]tivado, [D]esativado");

            Console.Write("Sensor de temperatura...:");
            t = Console.ReadLine().ToUpper()!;

            Console.Write("Sensor de Pressão.......:");
            p = Console.ReadLine().ToUpper()!;

            Console.Write("Sensor de Rotação...:");
            r = Console.ReadLine().ToUpper()!;

            Console.WriteLine();

            if (t != "A" || t != "D" || p != "A" || p != "D" || r != "A" || r != "D")
            {
                 Console.WriteLine("Digite Invalido\n");
            }
            else if (t != "A" && p != "A" && r != "D")
            {
                Console.WriteLine("Luz de advertência DESATIVADO.\n");
            }
            else if (t == "A" && p == "A")
            {
                Console.WriteLine("Luz de advertência ATIVADA.\n");
            }
            else if (t == "A" && r == "A")
            {
                Console.WriteLine("Luz de advertência ATIVADA.\n");
            }












            


        }
    }
}


//(t != "A" || t != "D" || p != "A" || )