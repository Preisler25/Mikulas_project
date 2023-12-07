using System;
namespace Mikulas
{
    class Ajándék
    {
        public string Név { get; set; }
        public double Súly { get; set; }
        public int Ár { get; set; }
        public string Címzett { get; set; }
        public string Kategória { get; set; }
        public bool Becsomagolva { get; set; }
        public string Gyártó { get; set; }
        public int RaktáronMennyiség { get; set; }
        public string Anyag { get; set; }
        public DateTime LejáratiDátum { get; set; }
        public bool Törékeny { get; set; }
        public string GyártásiOrszág { get; set; }
        public string SzállításiCím { get; set; }
        public bool Kiszállítva { get; set; }

        public Ajándék(string név, double súly, int ár, string címzett, string kategória,
                       bool becsomagolva, string gyártó, int raktáronMennyiség, string anyag,
                       DateTime lejáratiDátum, bool törékeny, string gyártásiOrszág,
                       string szállításiCím, bool kiszállítva)
        {
            Név = név;
            Súly = súly;
            Ár = ár;
            Címzett = címzett;
            Kategória = kategória;
            Becsomagolva = becsomagolva;
            Gyártó = gyártó;
            RaktáronMennyiség = raktáronMennyiség;
            Anyag = anyag;
            LejáratiDátum = lejáratiDátum;
            Törékeny = törékeny;
            GyártásiOrszág = gyártásiOrszág;
            SzállításiCím = szállításiCím;
            Kiszállítva = kiszállítva;
        }

        public void Becsomagolás()
        {
            Becsomagolva = true;
            Console.WriteLine($"{Név} be lett csomagolva.");
        }

        public void Szállítás(string cél)
        {
            SzállításiCím = cél;
            Console.WriteLine($"{Név} elindult a következő címre: {cél}.");
        }

        public void Kiszállítás()
        {
            Kiszállítva = true;
            Console.WriteLine($"{Név} sikeresen kiszállítva a címre: {SzállításiCím}.");
        }

        public void Ellenőrzés()
        {
            Console.WriteLine($"{Név} kiszállítva: {Kiszállítva}, lejárt: {LejáratiDátum < DateTime.Now}");
        }

        public void ÁrMódosítás(int újÁr)
        {
            Ár = újÁr;
            Console.WriteLine($"{Név} ára módosítva: {Ár} Ft.");
        }
    }
}