using System;

namespace media_1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());

            double N2 = double.Parse(Console.ReadLine());

            double med =N1 * 3.5;
             double ia =N2 *7.5;
            double media = med + ia;
            double mediaTotal = media / 11;
            Console.WriteLine($"MEDIA ={mediaTotal :.00000}");
        }
    }
}
