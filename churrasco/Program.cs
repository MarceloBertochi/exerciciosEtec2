/*
Faça um programa que calcule a quantidade de itens necessários para um churrasco a partir 
da quantidade de adultos (que consomem e que não consomem bebidas alcoólicas) e de crianças.

Item	        adulto	 criança
Carne	         400g	  200g
Acompanhamentos	 200g	  200g
Cerveja	2l	--
Refrigerante  	 500ml	 500ml
Água	         400ml	 400ml

Estime cerveja e refrigerantes de acordo com a indicação de consumo dos adultos. 
Estime refrigerante para todas as crianças. Estime água para todos.
*/

using System;

namespace Churrasco

{
    class programa

    {
        static void Main(string[] args)

        {
            Console.Clear();
            Console.WriteLine("-- Churrasco --");
            Console.WriteLine("");

            Console.Write("Digite o número de Adultos que consomem bebidas alcólicas....:");
            int adultoConsome = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número de Adulto que não consome bebida alcólicas...:");
            int adultoNConsome = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número de crianças................................:");
            int criancas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......:{adultoConsome}");
            Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...:{adultoNConsome}");
            Console.WriteLine($"crianças .......................................:{criancas}");
            Console.WriteLine("");

            //EQUAÇÃO PARA O RESULTADO DE CARNE POR PESSOAS
            double carneAd = 400, carneCr = 200, acomp = 200, cerv = 2, refri = 500, agua = 400;
            double totalCarne = (carneAd * (adultoConsome + adultoNConsome ) + (carneCr * criancas)) / 1000;

            //EQUAÇÃO PARA ACOMPANHAMENTOS
            double totalAcomp = (acomp *(adultoConsome + adultoNConsome + criancas)) / 1000;

            //EQUAÇÃO PARA CERVEJA
            double totalCerv = (cerv * adultoConsome );

            //EQUAÇÃO PARA REFRIGERANTE
            double totalRefri = (refri *(adultoNConsome + criancas)) / 1000;

            //EQUAÇÃO PARA AGUA
             double totalAgua = (agua *(adultoConsome + adultoNConsome + criancas)) / 1000;

            Console.WriteLine($"Carne............: {totalCarne:n1} Kg");
            Console.WriteLine($"Acompanhamento...: {totalAcomp:n1} Kg");
            Console.WriteLine($"Cerveja..........: {totalCerv:n1} L");
            Console.WriteLine($"Refrigerante.....: {totalRefri:n1} L");
            Console.WriteLine($"Água.............: {totalAgua:n1} L");
        }
    }
}