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

            char yen_sign = '\u00A5';
            char registered_sign = '\u00AE';
            char cyrillic_letterZhe = '\u0416';
            char letter_phi = '\u03A6';

            //Variables output
            Console.WriteLine(num_inteiro);
            Console.WriteLine(unsign_int);
            Console.WriteLine(long_int);
            Console.WriteLine(long_unsignint);
            Console.WriteLine();
            Console.WriteLine(yen_sign);
            Console.WriteLine(registered_sign);
            Console.WriteLine(cyrillic_letterZhe);
            Console.WriteLine(letter_phi);
        }
    }
}
