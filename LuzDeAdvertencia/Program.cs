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
            t = Console.ReadLine().ToUpper().Trim().Substring(0,1)!;
            if (t != "A" && t != "D")
            {
                Console.WriteLine("Situação inválida , digite A para Ativado ou D para desativado");
                return;
            }

            Console.Write("Sensor de Pressão.......:");
            p = Console.ReadLine().ToUpper().Trim().Substring(0,1)!;
            if (p != "A" && p != "D")
            {
                Console.WriteLine("Situação inválida , digite A para Ativado ou D para desativado");
                return;
            }            

            Console.Write("Sensor de Rotação...:");
            r = Console.ReadLine().ToUpper().Trim().Substring(0,1)!;
            if (r != "A" && r != "D")
            {
                Console.WriteLine("Situação inválida , digite A para Ativado ou D para desativado");
                return;
            }
            Console.WriteLine();
            

            if (t == "A" && (p == "A" || r == "D"))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" Luz de advertência ATIVADA");
                Console.ResetColor();
            }

            else
            {
                Console.WriteLine("Luz de advertência DESATIVADA");
            }
        }
    }
}


/*
(t != "A" || t != "D" || p != "A" || )
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
            */