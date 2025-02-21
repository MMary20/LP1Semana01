using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
        Console.WriteLine("Insire código: ");
            string numero_inteiro = Console.ReadLine();
            int numero = int.Parse(numero_inteiro);

            string numero_hexadecimal = Convert.ToString("x");
            char numero_unicode = Convert.ToChar(numero);

        Console.WriteLine("Caráter Unicode: " + numero_unicode);
        }
    }
}










        



