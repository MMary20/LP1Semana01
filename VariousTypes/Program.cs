using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            sbyte numero1 = -100;
            short numero2 = 2;
            int numero3 = 30;
            long numero4 = 40000;
            byte numero5 = 200;
            ushort numero6 = 50000;
            uint numero7 = 4000000000U;
            ulong numero8 = 6000000000000000UL;

            char carater1 = '\u2605';
            char carater2 = '\u2665';
            char carater3 = '\u27A4';
            char carater4 = '\u2756';

            float numero_real1 = 1.234f;
            double numero_real2 = 123456789.987654321;
            decimal numero_real3 = 123456789.987654321m;

            Console.WriteLine("sbyte: " + numero1);
            Console.WriteLine("short: " + numero2);
            Console.WriteLine("int: " + numero3);
            Console.WriteLine("long: " + numero4);
            Console.WriteLine("byte: " + numero5);
            Console.WriteLine("ushort: " + numero6);
            Console.WriteLine("uint: " + numero7);
            Console.WriteLine("ulong: " + numero8);
            Console.WriteLine("estrela: " + carater1);
            Console.WriteLine("coracao: " + carater2);
            Console.WriteLine("seta: " + carater3);
            Console.WriteLine("simbolo: " + carater4);
            Console.WriteLine("float: " + numero_real1);
            Console.WriteLine("double: " + numero_real2);
            Console.WriteLine("decimal: " + numero_real3);
        }
    }
}
