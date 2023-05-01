/*--- Múltiplo ---

Digite um número...........: 187
Avaliar se é múltiplo de...: 11

187 é múltiplo de 11
--- Múltiplo ---

Digite um número...........: 188
Avaliar se é múltiplo de...: 11

188 não é múltiplo de 11 */

using System;

namespace Multiplo

{
    class Program

    {
        static void Main(string[] args)

        {
            int numero, multiplo;
            
            Console.Clear();
            Console.WriteLine("-- Multiplos --");
            Console.WriteLine();

            Console.Write("Digite um número.................: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Avaliar se é multimpo de.........: ");
            multiplo = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine();

            if (numero % multiplo == 0)

            {
                Console.WriteLine($"O número {numero} é multimplo de {multiplo}");
            }
            else
            {
                Console.WriteLine($"O número {numero} não é multimplo de {multiplo}");
            }
        }
    }
}

