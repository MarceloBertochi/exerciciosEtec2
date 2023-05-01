using System;

namespace QuadranteCartesiano

{
    class Program

    {
        static void Main(string[] args)

        {
            Console.Clear();

            double x, y;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("--- Quadrante Cartesiano ---\n");
            Console.ResetColor();

            Console.WriteLine("--- Entre com o ponto desejado ---");
            Console.Write("Entre com a Cordenada X...:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com a Cordenada y...:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (x == 0 && y == 0)

            {
                Console.WriteLine($"O ponto ({x} {y}) fica na origem\n");

               Console.WriteLine($"          | Y = {y}");
                Console.WriteLine("          |");
                Console.WriteLine("          | ");
                Console.WriteLine("          |");
               Console.WriteLine($"          |         X = {x}");
                Console.WriteLine("----------0----------");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
                Console.WriteLine("          |");
            }

            else if (x > 0 && y > 0)
            {

                Console.WriteLine($"O ponto ({x} , {y})  fica no quadrante 1.\n");               

               Console.WriteLine($"             | Y = {y}");
                Console.WriteLine("             |");
                Console.WriteLine("             | Quadrante 01");
                Console.WriteLine("             |");
               Console.WriteLine($"             |         X = {x}");
                Console.WriteLine("---------------------------");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
            }

            else if (x < 0 && y > 0)

            {
                Console.WriteLine($"O ponto ({x} , {y})  fica no quadrante 2.\n");

               Console.WriteLine($"             | Y = {y}");
                Console.WriteLine("             |");
                Console.WriteLine("Quadrante 02 | ");
                Console.WriteLine("             |");
               Console.WriteLine($"             |         X = {x}");
                Console.WriteLine("---------------------------");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
                Console.WriteLine("             |");               
            }

            else if (x < 0 && y < 0)

            {
                Console.WriteLine($"O ponto ({x} , {y})  fica no quadrante 3.\n");

               Console.WriteLine($"             | Y = {y}");
                Console.WriteLine("             |");
                Console.WriteLine("             | ");
                Console.WriteLine("             |");
               Console.WriteLine($"             |         X = {x}");
                Console.WriteLine("---------------------------");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
                Console.WriteLine("Quadrante 03 |");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
            }

            else if (x > 0 && y < 0)

            {
                Console.WriteLine($"O ponto ({x} , {y})  fica no quadrante 4.\n");
               
               Console.WriteLine($"            | Y = {y}");
                Console.WriteLine("            |");
                Console.WriteLine("            | ");
                Console.WriteLine("            |");
               Console.WriteLine($"            |         X = {x}");
                Console.WriteLine("--------------------------");
                Console.WriteLine("            |");
                Console.WriteLine("            |");
                Console.WriteLine("            | Quadrante 04");
                Console.WriteLine("            |");
                Console.WriteLine("            |");
            }

            else
            {
                Console.WriteLine($"O ponto ({x} , {y})  fica no eixo das cordenasdas.\n");

               Console.WriteLine($"             | Y = {y}");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
               Console.WriteLine($"             |         X = {x}");
                Console.WriteLine("-------------0-------------");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
                Console.WriteLine("             |");
                Console.WriteLine("             |");

            }

            Console.WriteLine();
        }
    }
}