using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    class Program
    {
        public delegate void DortIslem(int sayi1, int sayi2);

        public static void TestMethod(Expression<Func<string, string, bool>> expression) { }
        static void Main(string[] args)
        {
            //Console.Write("1. Sayı: ");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayı: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //DortIslem dortIslem = Toplam;
            //dortIslem += Fark;
            //dortIslem += Carpim;
            //dortIslem += Bolum;

            //dortIslem(sayi1,sayi2);


            // action

            //List<string> liste = new List<string> { "Soner", "Hasan", "Merve", "Cihan", "Nuri" };

            //liste.ForEach(i => { Console.WriteLine(i); });

            //Action<string> myAction = delegate (string s) { Console.WriteLine(s); };
            //myAction("Soner");

            //Func<int, int, int> toplam = (x, y) => x + y;

            //// x=>x.Contains("Ha")

            //Func<string, string, bool> iceriyorMu = (x, y) => x.Contains(y);

            //Console.WriteLine(iceriyorMu("Hasan","e"));

            Method();
            Method2();


            Console.ReadKey();
        }


        public static async void Method()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Birinci method");
                    Task.Delay(100);
                }
            });

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Birinci method 2. for");
                await Task.Delay(50);
            }
        }

        public static void Method2()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("İkinci method");
                Task.Delay(100);
            }
        }

        public static void Toplam(int sayi1, int sayi2) => Console.WriteLine("Toplam: "+(sayi1+sayi2));
        public static void Fark(int sayi1, int sayi2) => Console.WriteLine("Fark: "+(sayi1-sayi2));
        public static void Carpim(int sayi1, int sayi2) => Console.WriteLine("Çarpım: "+(sayi1*sayi2));
        public static void Bolum(int sayi1, int sayi2) => Console.WriteLine("Bölüm: "+(sayi1/sayi2));
    }


}
