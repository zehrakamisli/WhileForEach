using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WhileForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while
            //1'den başlayarak consol dan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp consola yazdıran program.
            Console.WriteLine("********** While **********");
            Console.Write("Lütfen Bir Sayı Giriniz: ");
            int Sayi = int.Parse(Console.ReadLine());
            int Sayac = 1;
            int Toplam = 0;
            while (Sayac <= Sayi)
            {
                Toplam += Sayac;
                Sayac++;
            }
            Console.WriteLine("Ortalama: " + Toplam / Sayi);
            Console.WriteLine();
            //a'dan z'ye kadar tüm harfleri console yazdıran program
            char Character = 'a';
            while (Character < 'z')
            {
                Console.Write(Character);
                Character++;
                
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("********** ForEach **********");
            string[] Car = { "BMW", "Ford","Mercedes","Audi","Toyota","Nissan" };

            foreach (var x in Car)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
