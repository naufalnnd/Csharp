using System;
using System.Runtime.InteropServices;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mulai Program...");
            int i = 5;

            do
            {
                Console.WriteLine(new string('*', i));
                i--;
            }
            while (i > 0);

            do
            {
                Console.WriteLine(new string('*', i));
                i++;
            }
            while (i < 6);

            Console.WriteLine("Program Selesai");
        }
    }
}