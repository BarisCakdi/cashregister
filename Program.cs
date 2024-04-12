namespace cashregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba BC markete hoş geldiniz!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Kaç adet ürün girişi yapmak istiyorsunuz?");
            int adet = int.Parse(Console.ReadLine());

            int toplam = 0;
            Console.Clear();
            for (int i = 1; i <= adet; i++)
            {
                Console.Write(i + ". Ürünün fiyatını giriniz:");
                toplam += int.Parse(Console.ReadLine());
                Console.Clear();

            }
            Console.WriteLine("Sonuç: " + toplam + " tl");

            Console.Write("Ödeme Yönteme seçiniz / K.kartı(K)/Nakit(N): ");
            string answer = Console.ReadLine();
            if (answer == "K" || answer == "k")
            {
                //K.kart alanı
                Console.Write("K.kartı limitinizi giriniz: ");
                int kart = int.Parse(Console.ReadLine());
                Console.Clear();
                if (kart >= toplam) 
                {
                    Console.WriteLine("K.kartınızdan " + kart + " tl çekilmiştir.");
                    Console.WriteLine("K.kartınızda " + (kart - toplam) + " tl kalmıştır");
                    Console.WriteLine("İyi günler dileriz!");
                }
                else
                {
                    Console.WriteLine("Kart limitiniz " + kart + " tl yetersiz. " + (kart - toplam) + " tl eksik. Lütfen Kart bakiyenizi kontrol ediniz!");

                }

            }
            else
            {
                //Nakit alanı
                Console.Write("Nakit ücreti yazınız: ");
                int nakit = int.Parse(Console.ReadLine());
                Console.Clear();
                if(nakit >= toplam)
                {
                    Console.WriteLine("Nakit olarak " + nakit + " tl alınmıştır.");
                    Console.WriteLine("Para üstü " + (nakit - toplam) + " tl geri verilmiştir.");
                    Console.WriteLine("İyi günler dileriz!");
                }
                else
                {
                    Console.WriteLine("Verdiğiniz " + nakit + " tl yetersiz. " + (nakit - toplam) + " tl eksik. Lütfen tekrar deneyiniz!");
                }
            }

        }
    }
}
