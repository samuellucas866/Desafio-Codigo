using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());

            //Verifica se o número pertence ou não a sequência de Fibonacci.
            bool sequencia = VerificaSePertenceFibonacci(n);

            if (sequencia)
                Console.WriteLine($"O número {n} pertence à sequência de Fibonacci.");
            else
                Console.WriteLine($"O número {n} não pertence à sequência de Fibonacci.");


        }

        //método booleano para ver se a soma do primeiro termo e segundo chega ao valor de n
        //Pois a soma do primeiro e segundo termo, tem que fazer parte da sequência até n.
        static bool VerificaSePertenceFibonacci(int x)
        {
            int a = 0;
            int b = 1;

            while (b <= x)
            {
                if (b == x)
                    return true;

                int temp = a + b;
                a = b;
                b = temp;
            }

            return false;
        }
    }
}
