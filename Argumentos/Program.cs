using System;

namespace Argumentos
{
    /// <summary>
    /// This program prints out the arguments given by the program
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is the main function with the arguments.
        /// </summary>
        /// <param name="args"> Array de strings</param>
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
