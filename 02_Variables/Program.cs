using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables

            //double number;
            //number = 31.35;
            //Console.WriteLine(number);

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("-----Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("-----Portakal Birim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("-----Çilek Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("-----Patates Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("-----Tomates Birim Fiyatı:" + tomatoPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawTotalPrice = strawGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;





            //Console.WriteLine("Alınan Ürün Elma - "+ "Birim Fiyat:" +appleTotalPrice+ " - Gramaj:"+ appleGram + " -Toplam Tutar:" + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün Portakal - "+ "Birim Fiyat:" + orangePrice + " - Gramaj:"+ orangeGram + " -Toplam Tutar:" + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün Çilek - "+ "Birim Fiyat:" + strawberryPrice + " - Gramaj:"+ strawGram + " -Toplam Tutar:" + strawTotalPrice);
            //Console.WriteLine("Alınan Ürün Patates - "+ "Birim Fiyat:" + potatoPrice + " - Gramaj:"+ potatoGram + " -Toplam Tutar:" + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün Domates - "+ "Birim Fiyat:" + tomatoPrice + " - Gramaj:"+ tomatoGram + " -Toplam Tutar:" + tomatoTotalPrice);
            //Console.WriteLine();
            //double shoppinTotalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutar: "+shoppinTotalPrice+ " Tl");

            #endregion

            #region Char Variables

            //ABCDEFGH
            //DEFGHİJK
            //TOPLANTI SAAT 20:00'DE
            // "  '

            //Char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);



            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge,
            //    passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcu: " + passangerName +" "+ passangerSurname+       
            //    "   ***Yolcu Konum: " + passangerDistrict + "/" + passangerCity + "   ***Yolcu Yaş: " + passangerAge + "   ***Yolcu TC: " + passangerIdentityNumber);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, pcPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //pcPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, pcCount, chairCount, tvCount;


            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz:");
            //shoesCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız pc Sayısını Giriniz:");
            //pcCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız tv Sayısını Giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoePrice + pcCount * pcPrice + chairPrice * chairCount + tvPrice * tvCount;
            //    Console.WriteLine("Toplam Tutar:" + totalPrice + " TL");


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz:");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz:");
            //exam2=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz:");
            //exam3=double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız:" + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen Cinsiyet Seçiniz:");
            //gender=char.Parse(Console.ReadLine()); ;

            //Console.WriteLine("Seçtiğiniz Cinsiyet:" + gender); 


            
            
            
            
            
            #endregion

            

            Console.ReadLine();

            






        }
    }
}
