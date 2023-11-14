using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anaprojekod
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEĞİŞKENLER NEDİR ?, NE İŞE YARAR ?
            //Değişkenler bir proglama dilinde verilerin depolanma alanlarını temsil eder.Her değişkene bellekten bir alan ayrılır.

            //DEĞİŞKEN TÜRLERİ 
            
            byte birinci = 12;
            byte ikinci = 49;
            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.ReadLine();
            //tam sayılar için kullanılır.(0-255 aralığında değer alır.8bit)

            
            int sayi1, sayi2, toplam;
            sayi1 = 15;
            sayi2 = 10;
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
            Console.ReadLine();
            //int sayısal ifadelerde asla tırnak içine alınmaz..(32.bitlik işaretli tam sayıdır.)

            
            float ondalikli_sayi1 = 35.49f;
            float ondalikli_sayi2 = 21.63f;
            Console.WriteLine(ondalikli_sayi1);
            Console.WriteLine(ondalikli_sayi2);
            Console.ReadLine();
            //float veri tipi ondalıklı sayı veri tipidir. 7-8 basamak arasına kadar ondalıklı sayı tutabailir. sonuna f koymazsak eğer double veri tipini algılar.32.bitlik kayan sayı anlamına gelir.

            
            double birincideger = 15116;
            double ikincideger = 789523;
            Console.WriteLine(birincideger);
            Console.WriteLine(ikincideger);
            Console.ReadLine();
            //floata göre 15 basamağa kadar tanımlayabilir.(işaretli-işaretsiz farketmez 64.bitlik sayı alır)

           
            short birincisayi = -500;
            short ikincisayi = 2500;
            Console.WriteLine(birincisayi);
            Console.WriteLine(ikincisayi);
            Console.ReadLine();
            //negAtif tam sayılar da geçerlidir.(-32768-32768 aralığında değer alır. 16bit

            
            long sayi11 = 1561656555;
            long sayi22 = 159812189625615;
            Console.WriteLine(sayi11);
            Console.WriteLine(sayi22);
            Console.ReadLine();
            //long veri tipi 18-19 bas kadar tutabilen bir değişkendir.(64.bitlik büyük tamsayı değeri alır-işaretsiz)

            
            char karakter = 'Ö';
            char karakter2 = 'A';
            Console.WriteLine(karakter);
            Console.WriteLine(karakter2);
            Console.ReadLine();
            //char veri tipi karakteri tutmal için kullanılır ve tek tırnak kullanılır..(16 bitlik unicode şeklinde tek karakter alır.)


            bool kontroldeğişkeni = true;
            bool kontroldeğişkeni2 = false;
            bool sonuc = 10 < 5;
            Console.WriteLine(sonuc);
            Console.ReadLine();
            //(16 bitlik değer alır)

           
            object w1 = "ömer";
            object w2 = 5;
            object w3 = 3.26;
            Console.WriteLine(w1);
            Console.WriteLine(w2);
            Console.WriteLine(w3);
            Console.ReadLine();
            //tüm veri tiplerini tanıyan ve kabul eden veri tipidir

           
            string adi, soyadi;
            Console.Write("Adınızı Giriniz : ");
            adi = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz : ");
            soyadi = Console.ReadLine();
            Console.WriteLine("ADINIZ ve SOYADINIZ:: "+adi+" "+soyadi);
            Console.ReadLine();
            //metinsel bir değişken tipidir.


            sbyte veri1 = -35;
            sbyte veri2 = 49;
            Console.WriteLine("Değişken 1 :" + veri1);
            Console.WriteLine("Değişken 2 :" + veri2);
            Console.ReadLine();
            //(-128-127 aralığında değer alır. 8bit)


            ushort sayi21 = 0;
            ushort sayi35 = 2564;
            Console.WriteLine("ilk veri:" + sayi21);
            Console.WriteLine("iikinci veri :" + sayi35);
            Console.ReadLine();
            //(0 ile 65535 aralığında değer alır. 16bit)


            uint sayi49 = 8625963;
            uint sayi37 = 999999;
            Console.WriteLine("ilk sayı :" + sayi49);
            Console.WriteLine("ikinci sayı :" + sayi37);
            Console.ReadLine();


            ulong ücuncü = 1245;
            ulong dördünccü = 12552890123;
            Console.WriteLine("Birinci degisken: " + ücuncü);
            Console.WriteLine("Ikinci degisken: " + dördünccü);
            Console.ReadLine();
            //ulong türündeki değişkenler 64 bitlik (8 byte) işaretli veri depolarlar.(0 ve 18,446,744,073,709,551,615 arasında değer depolayabilmektedir.)


            decimal besinci = -78456562323.6m;
            decimal altinci = 13456789009876543456m;
            Console.WriteLine("Birinci degisken: " + besinci);
            Console.WriteLine("Ikinci degisken: " + altinci);
            Console.ReadLine();
            //(128 bitlik en büyük olandır.)


            Console.WriteLine("*********************************");

            
            //SABİT NEDİR ==> Program boyunca sabit kalacak veriler için kullanılan tanımlamalardır.
            //Bir sabit tanımlamak için const anahtar kelimesini kullanırız.
            //Değişken program içerisinde farklı değerler alabilirken sabit program süresince tanımlandığı değeri korur.

            const double pi = 3.14;
            const string ad = "ömer";
            const int mus = 49;
            // const ifadesini anlamı double değişken artık değerinin değişemeyeceği anlamına gelir..

        }
    }
}
