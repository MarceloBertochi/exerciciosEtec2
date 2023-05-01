using System;

namespace FluxogramaDaEngenharia

{
    class Program

    {
        static void Main(string[] args)

        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-- Fluxograma Da Engenharia --\n".ToUpper());
            Console.ResetColor();

            string movendo, deveria;

            Console.Write("O objeto está se movendo? (S/N)\n");
            movendo = Console.ReadLine()!.ToUpper();

            if (movendo == "S") // PERGUNTA DO TOPO

            {
                Console.Write("Deveria se mover? (S/N) \n");
                deveria = Console.ReadLine()!.ToUpper();
                
                {
                    if (deveria == "S")
                    {
                        Console.WriteLine("Ótimo");
                    }
                    else
                    {
                        Console.WriteLine("Use silvertape");
                    }
                }
            }

            else
            {
                Console.Write("Deveria se mover? (S/N) \n");
                deveria = Console.ReadLine()!.ToUpper();

                {
                    if (deveria == "S")
                    {
                        Console.WriteLine("Use WD40");
                    }
                    else
                    {
                        Console.WriteLine("Ótimo");
                    }
                }
            }
        }
    }
}