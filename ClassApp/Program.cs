namespace SınıfYoklama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> OgrenciList = new();
            OgrenciList.Add(new Ogrenci() { İsim = "Elif", OgrenciNumarası = 123, SınıftaMı = true });
            OgrenciList.Add(new Ogrenci() { İsim = "Halil", OgrenciNumarası = 124, SınıftaMı = false });
            OgrenciList.Add(new Ogrenci() { İsim = "Füsun", OgrenciNumarası = 125, SınıftaMı = true });
            OgrenciList.Add(new Ogrenci() { İsim = "Cumhan", OgrenciNumarası = 126, SınıftaMı = true });
            OgrenciList.Add(new Ogrenci() { İsim = "Şeref", OgrenciNumarası = 127, SınıftaMı = false });
            OgrenciList.Add(new Ogrenci() { İsim = "Tuğçe", OgrenciNumarası = 128, SınıftaMı = true });
            OgrenciList.Add(new Ogrenci() { İsim = "Bade", OgrenciNumarası = 129, SınıftaMı = false });

            Console.WriteLine("Hocam lütfen isminizi giriniz:");
            string hoca = Console.ReadLine();
            Console.WriteLine($"Sınıf yoklaması uygulamamıza hoşgeldiniz {hoca} hocam");
            Console.WriteLine("Hangi işlemi yapmak istiyorsanız lütfen aşağıda ki seçeneklerden uygun olanın işlem numarasını seçiniz: ");
            Console.WriteLine("1 ---> Öğrenci Listesi");
            Console.WriteLine("2 --> Yoklama almak");
            Console.WriteLine("3 --> Derse gelmeyenler");
            Console.WriteLine("4 --> Uygulamadan çıkmak");

            int secenek = 0;

            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemin numarasını giriniz?");
                string cevap = Console.ReadLine();

                if (!int.TryParse(cevap, out secenek))
                {
                    Console.WriteLine("Lütfen rakam olarak seçiminizi yapınız:");
                    continue;
                }

                if (secenek > 5 || secenek < 0)
                {
                    Console.WriteLine("Doğru seçeneği seçtiğinizden emin olunuz.");
                    continue;
                }

                if (secenek == 1)
                {
                    Console.WriteLine("Öğrencilerin Listesi:");

                    foreach (var Ogrenci in OgrenciList)
                    {
                        Console.WriteLine(Ogrenci.OgrenciNumarası + " " + Ogrenci.İsim);
                    }
                    continue;
                }

                if (secenek == 2)
                {
                    Console.WriteLine("Öğrencinin sınıfta olup olmadığını giriniz:");

                    foreach (var Ogrenci in OgrenciList)
                    {
                        Console.WriteLine(Ogrenci.OgrenciNumarası + " " + Ogrenci.İsim + "   Öğrenci sınıftaysa true sınıfta değil is false giriniz:");
                        Ogrenci.SınıftaMı = bool.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("İşleminiz tamamlanmıştır.");
                    continue;
                }

                if (secenek == 3)
                {
                    Console.WriteLine("Derste olmayan öğrencilerin listesi:");
                    var sınıftaOlmayanlar = OgrenciList.Where(p => p.SınıftaMı == false).ToList();

                    foreach (var Ogrenci in sınıftaOlmayanlar)
                    {
                        Console.WriteLine(Ogrenci.OgrenciNumarası + " " + Ogrenci.İsim);
                    }
                    continue;
                }

                if (secenek == 4)
                {
                    Console.WriteLine("Programdan çıkış yapılıyor.");
                    break;
                }
            }
        }
    }
}

public class Ogrenci
{
    public string İsim;
    public bool SınıftaMı;
    public int OgrenciNumarası;
}