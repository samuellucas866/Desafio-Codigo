using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;


            Console.WriteLine("Digite uma sequência de números separados por vírgula: ");
            string input = Console.ReadLine();

            int[] num = ParseInput(input);

            bool aumentaDeDois = VerificaSeAumenta(num);

            if (aumentaDeDois)
            {
                Console.WriteLine("A sequência aumenta de 2 em 2");
            }
            else
            {
                Console.WriteLine("A sequência não aumenta de 2 em 2");
            }

        }

        //Método para que remova os espaços em brancos e verifique os números entre as vírgulas.
        static int[] ParseInput(string input)
        {
            return input.Split(',')
                        .Select(s => int.Parse(s.Trim()))
                        .ToArray();
        }

        //Método para verificar se a ordem/sequência dos números estão aumentando de
        //2 em 2 ou não estão aumentando de 2 em 2.
        static bool VerificaSeAumenta(int[] numeros)
        {
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] != numeros[i - 1] + 2)
                    return false;
            }
            return true;
        }


    }


}

