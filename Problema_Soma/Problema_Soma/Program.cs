using System.Globalization;
using System.Runtime.Serialization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int indice = 13, soma =0,k=0;

            while(k < indice)
            {
                k= k+1;

                soma = soma + k;
            }

            Console.Write("Soma = "+soma);
            

        }
    }
}