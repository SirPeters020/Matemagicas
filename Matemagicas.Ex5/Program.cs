using System;

namespace Matemagicas.Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());


            double funcaoDeise = (4 * Math.Sqrt(x)) + (Math.Sqrt(y));
            double funcaoSilva = (Math.Pow(x, 3)) + (2 * Math.Sqrt(y));
            double funcaoTabata = (-50 * x) + (Math.Pow(y, 3));

            if (funcaoDeise > funcaoSilva && funcaoDeise > funcaoTabata)
            {
                Console.WriteLine("Deise Venceu!");
            }
            else if (funcaoSilva > funcaoDeise && funcaoSilva > funcaoTabata)
            {
                Console.WriteLine("Silva Venceu!");
            }
            else if (funcaoTabata > funcaoDeise && funcaoTabata > funcaoSilva)
            {
                Console.WriteLine("Tabata Venceu!");
            }
            else
            {
                Console.WriteLine("Empate!");
            }

        }
    }
}
