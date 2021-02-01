using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi
            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Programlamaya Başlangıç Kursu", "Java", "C#" };

            for (int i=0; i<kurslar.Length; i=i+1)
            {
                Console.WriteLine(kurslar[i);
            }

            //üsttekiyle alttaki aynı şey. alttakini tercih et.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Hello World!");
        }
    }
}
