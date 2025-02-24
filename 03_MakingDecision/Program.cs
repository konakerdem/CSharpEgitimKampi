using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password=Console.ReadLine();

            //if (password == "abcd")
            //{

            //    Console.WriteLine("Şifre Doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();


            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country == "türkiye")
            //{

            //    Console.WriteLine("veriler doğrulandı");
            //}

            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int number;

            //Console.WriteLine("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5) 
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}


            //int exam1, exam2, exam3, average;
            //string result=""; 
            ////resulta ilk değer ataması yapmamızı istiyor şayet hiç bir koula uymazsa tanımsız kalmasın diye veya else içinde tanımlaman gerekli


            //Console.Write("Sınav1: ");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());



            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);    


            //if(average>0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average >70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average >84)
            //{
            //    result = "Sonuç Çok İyi";
            //}



            //Console.WriteLine(result);
            ////sonuç - çıkarsa hata verir?? hiç bir if e giremediği için



            //string city;
            //Console.Write("Şhir girişi yapınız: ");
            //city = Console.ReadLine();
            //if (city == "Adana" | city=="Ankara" | city=="Bursa" | city=="Trabzon") 
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else 
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.WriteLine("Lütfen Kullanıcı Adı Giriniz: ");
            //string username=Console.ReadLine();

            //if(username !="admin")
            //{
            //    Console.WriteLine("Bu Kullanıcı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}




            #endregion

            #region Mod İşlemleri

            //int number=26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2=int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1.Sayının 2.sayıya bölümünden kalan: " + result);



            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if(number%2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir ! ");
            //}

            //else
            //{
            //    Console.WriteLine("Sayı Tektir ! ");
            //}


            #endregion

            #region Char Değişkenler İle Karar Yapıları
            //char team;

            //Console.Write("Lütfen takım sembolünü girini: ");
            //team=char.Parse(Console.ReadLine());

            //if(team=='g' | team == 'G')
            //{
            //    Console.WriteLine("Galatarasay");
            //}


            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("**** C Sharp Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();//integer a çevirmedik

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------Ana Yemekler---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("--------------------Ana Yemekler---------------------");

            //}


            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------Çorbalar---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("--------------------Çorbalar---------------------");

            //}



            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------Pizzalar---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("--------------------Pizzalar---------------------");

            //}


            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------İçecekler---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola ");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("--------------------İçecekler---------------------");

            //}


            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------------Tatlılar---------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe ");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("--------------------Tatlılar---------------------");

            //}






            #endregion


            #region Switch Case
            //Console.WriteLine("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());


            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;

            //    default: Console.Write("Hatalı Veri Girişi"); break;


            //}



            #endregion



            #region Switch Case Hesap Makinesi


            int number1, number2, result;

            char symbol;

            Console.WriteLine("1.Sayıyı Giriniz: ");
            number1=int.Parse(Console.ReadLine());


            Console.WriteLine("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol=char.Parse(Console.ReadLine());


            switch (symbol)
            {
                case '+': 
                    result=number1 + number2;
                    Console.WriteLine("Toplam: " +result);
                    break;


                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;
d

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;


            }





            #endregion







            Console.Read();



        }
    }
}
