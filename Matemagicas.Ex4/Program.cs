using System;

namespace Matemagicas.Ex4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha uma opção, Tempo(1), Valor futuro (2), Investimento necessario(3), Sair(4)");
            int opcao = Convert.ToInt32(Console.ReadLine());

            // declarando todas as variaveis que vou usar
            double investimento = 0;
            double montante = 0;
            double juros = 0;
            double valorAtualizado = 0;
            int contadorMeses = 0;
            int tempo = 0;
            switch (opcao)
            {
                case 1:
                    investimento = Convert.ToDouble(Console.ReadLine());
                    montante = Convert.ToDouble(Console.ReadLine());
                    juros = Convert.ToDouble(Console.ReadLine());
                    valorAtualizado = investimento;
                    contadorMeses = 0;

                    while (valorAtualizado < montante)
                    {
                        var valorAdicional = (((juros * 100) * valorAtualizado) / 10000); ;
                        valorAtualizado += valorAdicional;
                        contadorMeses++;
                    }
                    Console.WriteLine(contadorMeses);
                    break;
                case 2:
                    investimento = Convert.ToDouble(Console.ReadLine());
                    juros = Convert.ToDouble(Console.ReadLine());
                    tempo = Convert.ToInt32(Console.ReadLine());
                    valorAtualizado = investimento;
                    for (int i = 0; i <= tempo; i++)
                    {
                        var valorAdicional = (((juros * 100) * valorAtualizado) / 10000);
                        valorAtualizado += valorAdicional;
                    }
                    Console.WriteLine(valorAtualizado);
                    break;
                case 3:
                    montante = Convert.ToDouble(Console.ReadLine());
                    juros = Convert.ToDouble(Console.ReadLine());
                    tempo = Convert.ToInt32(Console.ReadLine());
                    valorAtualizado = montante;
                    for (int i = 0; i <= tempo; i++)
                    {
                        valorAtualizado -= (((juros * 100) * valorAtualizado) / 10000);
                    }
                    Console.WriteLine(valorAtualizado);
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Opção Inválida !");
                    break;
            }

        }
    }
}
