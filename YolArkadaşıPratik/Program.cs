using System;
class program
{
    static void Main(string[] args)
    {
      

        Console.WriteLine("Bodrum (Paket başlangıç fiyatı 4000 TL)");
        Console.WriteLine("Marmaris (Paket başlangıç fiyatı 3000 TL)");
        Console.WriteLine("Çeşme (Paket başlangıç fiyatı 5000 TL)");
        Console.WriteLine("Hangi lokasyona tatile gitmek istersiniz");

        string tercih = Console.ReadLine().ToLower();
        int ücret = 0;

        switch (tercih)
        {
            case "bodrum":
                ücret = 4000;
                break;

            case "marmaris":
                ücret = 3000;
                break;
            case "çeşme":
                ücret = 5000;
                break;

            default:
                Console.WriteLine("Lütfen geçerli bir lokasyan tercih ediniz");
                break;

        }

        int KisiSayısı = 0;

        Console.WriteLine("Kaç kişi tatile gideceksiniz");
        KisiSayısı=Convert.ToInt32(Console.ReadLine());


        int ulaşım = 0;
        int ulasımÜcreti = 0;
        Console.WriteLine("1. Seçenek----Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL) )");
        Console.WriteLine("2. Seçenek----Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
        Console.WriteLine("Tatile nasıl gitmeyi tercih edersiniz? (1 veya 2)");
        ulaşım = Convert.ToInt32(Console.ReadLine());

        switch (ulaşım)
        {
            case 1:
                Console.WriteLine("kara yolunu tercih ettiniz");
                ulasımÜcreti = 1500;
                break;
            case 2:
                Console.WriteLine("Hava yolunu tercih ettiniz");
                ulasımÜcreti = 4000;
                break;
            default:
                Console.WriteLine("Geçersiz bir tercih yaptınız.");
                break;


        }

        int toplamUcret = (KisiSayısı * ulasımÜcreti) + ücret;

        Console.WriteLine("Toplam ücretiniz " + toplamUcret);

        Console.WriteLine("Başka bir tatil planlamak ister misiniz (Evet/Hayır)");
        string devam = Console.ReadLine().ToLower();

        if (devam != "evet")
        {
            Console.WriteLine("İyi günler dileriz");
        }



    }
}
