using System.Security.Cryptography;

namespace RolagemDeDados

{
    class Program

    {
        static void Main(string[] args)

        {
            Console.Clear();
            Console.WriteLine("-- Rolagem de dados --");
            Console.WriteLine();

            Console.Write("Quantas faces tem o dado? ..: ");
            int faces = Convert.ToInt32(Console.ReadLine());

            int rolagem = RandomNumberGenerator.GetInt32(1, faces);

            Console.WriteLine($"Rolagem: {rolagem}");

        }
    }
}
