using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            //Integers of diferent types.
            int num_inteiro = 4;
            uint unsign_int = 12U;
            long long_int = 134L;
            ulong long_unsignint = 11UL;

            //Char variables using unicode values
            char yen_sign = '\u00A5';
            char registered_sign = '\u00AE';
            char cyrillic_letterZhe = '\u0416';
            char letter_phi = '\u03A6';



            //Variables output
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n ", num_inteiro, unsign_int, long_int, long_unsignint);
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", yen_sign, registered_sign, cyrillic_letterZhe, letter_phi);
        }
    }
}
