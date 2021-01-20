using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Donguler - Tekrar etmek için kullanılan yapılardır

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python", "C#" };  


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //foreach - Dizi temelli yapıları tek tek dönmeye yarıyor
            //kurs - alias - takma ad

            Console.WriteLine("For Dongusu Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");

        }
    }
}
