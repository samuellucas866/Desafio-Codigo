using System.Globalization;

namespace Programa
{
    class program
    {
        static void Main(String[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            string formataString = "Nome";

            string invercaoString = InverteString(formataString);

            Console.WriteLine("String original = " + formataString);

            Console.WriteLine("String invertida = " + invercaoString);


            static string InverteString(string formataString)
            {
                char[] caractere = formataString.ToCharArray();

                int tipo = caractere.Length;

                char[] inverte = new char[tipo];

                for (int i = 0; i < tipo; i++)
                {
                    inverte[i] = caractere[tipo - 1 - i];
                }

                return new string(inverte);
            }
        }
    }
}