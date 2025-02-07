/*
 *


       string[] menuler = { "Adana Kebap", "Urfa Kebap", "Karışık Pizza", "Kola", "Ayran" };
        double[] fiyatlar = { 200.0, 200.0, 150.0, 50.0, 30.0 };
        double toplamTutar = 0;

        Console.WriteLine("========================================");
        Console.WriteLine("            *** KAFE MENÜ ***           ");
        Console.WriteLine("========================================");
        for (int i = 0; i < menuler.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuler[i],-20} {fiyatlar[i],5} TL");
        }
        Console.WriteLine("========================================");

        Console.WriteLine("Lütfen sipariş etmek istediğiniz ürünlerin numaralarını girin (Tamamlamak için 0'a basın):");
        while (true)
        {
            Console.Write("Ürün numarası: ");
            int secim;
            while (!int.TryParse(Console.ReadLine(), out secim) || secim < 0 || secim > menuler.Length)
            {
                Console.Write("Geçerli bir numara giriniz: ");
            }

            if (secim == 0)
                break;

            Console.WriteLine($"Seçilen ürün: {menuler[secim - 1]} - {fiyatlar[secim - 1]} TL");
            toplamTutar += fiyatlar[secim - 1];
        }

        Console.WriteLine("========================================");
        Console.WriteLine($"Toplam Tutar: {toplamTutar} TL");
        Console.WriteLine("========================================");

*/
using System.Xml.Serialization;
using System.Threading;
Console.WriteLine("                 ANA MENU                     ");

// İşlem menusu dizisi
string[] islemler = { "Masa Aç[1]", "Masa İşlem[2]", "Masa Hesap[3]", "Çıkış [0]" };
//toplamda 5 masa vardır. 1 ve 3. masalar doludur. 
string[] masalar = { "MASA[1]___[BOŞ]", "MASA[2]___[BOŞ]", "MASA[3]___[DOLU]", "MASA[4]___[BOŞ]", "MASA[5]___[DOLU]" };


for (int i = 0; i < islemler.Length; i++) { Console.WriteLine("\t" + islemler[i]); }

Console.Write(" İşlem numarasını girin: ");
int islem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n \n -----------------------------------------\n \n");
if (islem == 1)
{
    
    for (int i = 0; i < masalar.Length; i++) { Console.WriteLine("\t" + masalar[i]); }
    Console.Write("Hangi masayı açıyorsunuz:  ");
    int masanumarasi = Convert.ToInt16(Console.ReadLine());
    while(masanumarasi == 3 || masanumarasi == 5)  // BURADA masalar dizisindeki elemanların içinde DOLU harfleri varsa masa dolu uyarısını vereceğiz.
    {
        Console.WriteLine("Bu masa Doludur, farklı bir masa seçiniz...");
        Console.Write("Hangi masayı açıyorsunuz:  ");
        masanumarasi = Convert.ToInt16(Console.ReadLine());
    }


    masalar[masanumarasi-1] = "MASA" + (masanumarasi) + "___[DOLU]";
    Console.Write("------------" + masanumarasi + ". Masa Açılmıştır."); Thread.Sleep(1000); Console.Write("Menü seçim ekranı geliyor."); Thread.Sleep(500); Console.Write("."); Thread.Sleep(600); Console.WriteLine("."); Thread.Sleep(500);
    foreach(string m in masalar) { Console.WriteLine(m); }

}



