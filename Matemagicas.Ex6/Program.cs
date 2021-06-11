using System;

namespace Matemagicas.Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = Convert.ToInt32(Console.ReadLine());
            double cambio = Convert.ToDouble(Console.ReadLine());
            double total = Math.Round(valor * cambio, 2);
            double valorComparacao = total;
            int notasCem = 0;
            int notasCinquenta = 0;
            int notasVinte = 0;
            int notasDez = 0;
            int notasCinco = 0;
            int notasDois = 0;
            int moedasUmReal = 0;
            int moedasCinquenta = 0;
            int moedasVinteCinco = 0;
            int moedasDez = 0;
            int moedasCinco = 0;
            int moedasUm = 0;

            while (valorComparacao >= 100)
            {
                notasCem++;
                valorComparacao -= 100;
            }
            while (valorComparacao >= 50)
            {
                notasCinquenta++;
                valorComparacao -= 50;
            }
            while (valorComparacao >= 20)
            {
                notasVinte++;
                valorComparacao -= 20;
            }
            while (valorComparacao >= 10)
            {
                notasDez++;
                valorComparacao -= 10;
            }
            while (valorComparacao >= 5)
            {
                notasCinco++;
                valorComparacao -= 5;
            }
            while (valorComparacao >= 2)
            {
                notasDois++;
                valorComparacao -= 2;
            }

            while (valorComparacao >= 1)
            {
                moedasUmReal++;
                valorComparacao -= 1;
            }

            while (valorComparacao >= 0.50)
            {
                moedasCinquenta++;
                valorComparacao -= 0.50;
            }

            while (valorComparacao >= 0.25)
            {
                moedasVinteCinco++;
                valorComparacao -= 0.25;
            }

            while (valorComparacao >= 0.10)
            {
                moedasDez++;
                valorComparacao -= 0.10;
            }
            while (valorComparacao >= 0.05)
            {
                moedasCinco++;
                valorComparacao -= 0.05;
            }
            while (valorComparacao >= 0.01)
            {
                moedasUm++;
                valorComparacao -= 0.01;
            }

            Console.WriteLine($"Valor: {valor}");
            Console.WriteLine($"Cambio: {cambio}");
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"100,00: {notasCem}");
            Console.WriteLine($"50,00 {notasCinquenta}");
            Console.WriteLine($"20,00 {notasVinte}");
            Console.WriteLine($"10,00 {notasDez}");
            Console.WriteLine($"05,00 {notasCinco}");
            Console.WriteLine($"02,00 {notasDois}");
            Console.WriteLine($"01,00 {moedasUmReal}");
            Console.WriteLine($"00,50 {moedasCinquenta}");
            Console.WriteLine($"00,25 {moedasVinteCinco}");
            Console.WriteLine($"00,10 {moedasDez}");
            Console.WriteLine($"00,05 {moedasCinco}");
            Console.WriteLine($"00,01 {moedasUm}");

        }
    }
}
