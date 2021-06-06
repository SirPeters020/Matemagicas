using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matemagicas.Ex1
{
    public static class Triangulo
    {
        // VERIFICA SE É UM TRIANGULO A PARTIR DOS LADO
        public static bool EUmTrianguloPorLado(float lado1, float lado2, float lado3)
        {
            if((lado1 + lado2 > lado3) || (lado1 + lado3 > lado2) || (lado2 + lado3 > lado1))
            {
                return true;
            }
            Console.WriteLine("NÃO É POSSÍVEL FORMAR UM TRIÂNGULO!");
            return false;
        }

        public static void TipoTrianguloPorLado(float lado1, float lado2, float lado3)
        {
            if (Equilatero(lado1, lado2, lado3))
            {
                // imprime caso seja equilatero
                Console.WriteLine("E");
            }
            else if (Isosceles(lado1, lado2, lado3))
            {
                // imprime caso seja Isosceles
                Console.WriteLine("I");
            }
            else if (Escaleno(lado1, lado2, lado3))
            {
                // imprime caso seja Escaleno
                Console.WriteLine("A");
            }
        }

        public static bool Equilatero(float lado1, float lado2, float lado3)
        {
            if ((lado1 == lado2) && (lado1 == lado3))
            {
                return true;
            }
            return false;
        }
        
        public static bool Isosceles(float lado1, float lado2, float lado3)
        {
            if ((lado1 == lado2) || (lado2 == lado3) || (lado1 == lado3))
            {
                return true;
            }
            return false;
        }

        public static bool Escaleno(float lado1, float lado2, float lado3)
        {
            if ((lado1 != lado2) && (lado2 != lado3) && (lado1 != lado3))
            {
                return true;
            }
            return false;
        }

        // VERIFICA SE É UM TRIANGULO A PARTIR DOS ANGULOS
        public static bool EUmTrianguloPorAngulo(float angulo1, float angulo2, float angulo3)
        {
            if(angulo1 + angulo2 + angulo3 == 180)
            {
                return true;
            }
            Console.WriteLine("NÃO É POSSÍVEL FORMAR UM TRIÂNGULO!");
            return false;
        }

        public static void TipoTrianguloPorAngulo(float angulo1, float angulo2, float angulo3)
        {
            if(Retangulo(angulo1, angulo2, angulo3))
            {
                // imprime caso seja Retangulo
                Console.WriteLine("R");
            }
            else if(Obtusangulo(angulo1, angulo2, angulo3))
            {
                // imprime caso sejaObtusangulo
                Console.WriteLine("O");
            }
            else if(Acutangulo(angulo1, angulo2, angulo3))
            {
                // imprime caso seja Acutangulo
                Console.WriteLine("A");
            }
        }


        public static bool Retangulo(float angulo1, float angulo2, float angulo3)
        {
            if ((angulo1 == 90) || (angulo2 == 90) || (angulo3 == 90))
            {
                return true;
            }
            return false;
        }

        public static bool Obtusangulo(float angulo1, float angulo2, float angulo3)
        {
            if ((angulo1 > 90) || (angulo2 > 90) || (angulo3 > 90))
            {
                return true;
            }
            return false;
        }

        public static bool Acutangulo(float angulo1, float angulo2, float angulo3)
        {
            if ((angulo1 < 90) || (angulo2 < 90) || (angulo3 < 90))
            { 
                return true;
            }
            return false;
        }

    }
}
