using System;

namespace Matemagicas.Ex1
{
    class Executavel
    {
        static void Main(string[] args)
        {
            // pegando caracter
            string ladoOuAngulo = Console.ReadLine();
            // pegando valores
            float valor1 = Convert.ToInt32(Console.ReadLine());
            float valor2 = Convert.ToInt32(Console.ReadLine());
            float valor3 = Convert.ToInt32(Console.ReadLine());

            // verificando se caracter selecionada foi L
            if (ladoOuAngulo.Equals("L"))
            {
                // verificando se pode ser um triangulo
                bool isTriangulo = Triangulo.EUmTrianguloPorLado(valor1, valor2, valor3);
                if (isTriangulo)
                {
                    // verificando tipo de triangulo
                    Triangulo.TipoTrianguloPorLado(valor1, valor2, valor3);
                }
            }
            // verificando se caracter selecionado foi A
            else if (ladoOuAngulo.Equals("A"))
            {
                // verificando se pode ser um triangulo
                bool isTriangulo = Triangulo.EUmTrianguloPorAngulo(valor1, valor2, valor3);
                if (isTriangulo)
                {
                    // verificando tipo de triangulo
                    Triangulo.TipoTrianguloPorAngulo(valor1, valor2, valor3);
                }
            }
            // caso caracter selecionado tenha sido invalido
            else
            {
                Console.Write("CARACTER INVALIDO");
            }
        }
    }
}
