using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (i < alphabet.Length - 2)
                {
                    Console.Write(alphabet[i] + alphabet[i + 1] + " "); 
                }

                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
