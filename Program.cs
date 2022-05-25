using System;

namespace Odev1_2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Kaç adet pozitif Sayı Gireceksiniz:");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("Bölünecek Sayıyı Giriniz:");
            int m = Int32.Parse(Console.ReadLine());

            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                 Console.Write("{0}. Sayı Giriniz:",i+1);
                 dizi[i]=Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Girdiğiniz Sayılardan {0} sayısına eşit veya tam bölünenler",m);
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var item in dizi)
            {
                if (item%m==0)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
