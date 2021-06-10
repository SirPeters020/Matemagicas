using System;

namespace Matemagicas.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // lendo valores
            string anosTexto = Console.ReadLine();
            // separando eles
            string[] anos = anosTexto.Split(" ");
            // colocando em variaveis separadas
            int primeiroAno = Convert.ToInt32(anos[0]);
            int segundoAno = Convert.ToInt32(anos[1]);

            if (primeiroAno < segundoAno)
            {
                // contador de anos
                int count = 0;
                for (int i = primeiroAno; i <= segundoAno; i++)
                {
                    // se divisivel por 4
                    if (i % 4 == 0)
                    {
                        // se for divisivel por 100 e não for por 400 vai dar vai dar verdadeiro
                        // porem a "!" no inicio inverte, então dara false e não ira imprimir nas tela
                        if (!(i % 100 == 0) && (i % 400 != 0))
                        {
                            Console.WriteLine(i);
                            count++;
                        }
                    }
                }
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("Erro: O primeiro ano deve ser menor que o segundo.");
            }

            
        }
    }
}
