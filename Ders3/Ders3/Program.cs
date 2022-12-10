using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            Console.Write("Sayı 1: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sayı 2: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam = "+toplam);
            Console.Read();
        }
    }
}
