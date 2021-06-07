using System;
using System.Collections.Generic;

namespace Matemagicas.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // lendo valores
            var valoresText = Console.ReadLine();
            // procurando o "-1" no texto
            var index = valoresText.IndexOf("-1");
            // recortando o "-1"
            var valoresTextoFormatado = valoresText.Substring(0, index-1);
            // separando os valores em um conjunto (array)
            var conjuntoValoresText = valoresTextoFormatado.Split(" ");

            var valoresEmNumeros = new List<int>();
            // adicionando cada valor do conjunto em uma lista
            foreach(string item in conjuntoValoresText)
            {
                valoresEmNumeros.Add(Convert.ToInt32(item));
            }
            // ordenando a lista ao contrario (do maior para o menos)
            valoresEmNumeros.Reverse();

            int[] valores = new int[conjuntoValoresText.Length];
            int count = 0;
            // colocando valores da lista em um cconjunto(array)
            foreach (int item in valoresEmNumeros)
            {
                valores[count] = item;
                count++;
            }
            
            // operacao principal
            for(int i = 0; i <= 2; i++)
            {
                // se tiver menos que 3 itens E o loop atual for maior do que o tamanho maximo do cconjunto
                if ((valores.Length < 3) && (i > valores.Length - 1))
                {
                    Console.WriteLine("NÃO HÁ JOGADOR");
                    break;
                }
                Console.WriteLine(valores[i]);
            }
            
        }
    }
}
