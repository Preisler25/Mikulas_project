using System;
namespace Mikulas
{
    class MikulásMűhely
    {
        public List<Ajándék> AjándékLista { get; set; }
        public Ajándék[] AjándékTömb { get; set; }
        public string Műhelyvezető { get; set; }
        public bool MűhelyNyitva { get; set; }

        public MikulásMűhely(string műhelyvezető)
        {
            AjándékLista = new List<Ajándék>();
            AjándékTömb = new Ajándék[100]; // Például 100 elemű tömböt létrehozunk
            Műhelyvezető = műhelyvezető;
            MűhelyNyitva = false;
        }

        public void AjándékHozzáadásaListához(Ajándék ajándék)
        {
            AjándékLista.Add(ajándék);
        }

        public void AjándékHozzáadásaTömbhöz(Ajándék ajándék, int index)
        {
            if (index >= 0 && index < AjándékTömb.Length)
            {
                AjándékTömb[index] = ajándék;
            }
            else
            {
                Console.WriteLine("Hibás index!");
            }
        }

        public void BecsomagoltAjándékokMegjelenítése()
        {
            Console.WriteLine("Becsomagolt ajándékok:");
            foreach (var ajándék in AjándékLista)
            {
                if (ajándék.Becsomagolva)
                {
                    Console.WriteLine(ajándék.Név);
                }
            }
        }

        public void LejártAjándékokEllenőrzése()
        {
            Console.WriteLine("Lejárt ajándékok:");
            foreach (var ajándék in AjándékLista)
            {
                if (ajándék.LejáratiDátum < DateTime.Now)
                {
                    Console.WriteLine(ajándék.Név);
                }
            }
        }

        public void TörékenyAjándékokEllenőrzése()
        {
            Console.WriteLine("Törékeny ajándékok:");
            foreach (var ajándék in AjándékLista)
            {
                if (ajándék.Törékeny)
                {
                    Console.WriteLine(ajándék.Név);
                }
            }
        }

        public void EredetiOrszágbeliAjándékokMegjelenítése(string ország)
        {
            Console.WriteLine($"Ajándékok az {ország} országból:");
            foreach (var ajándék in AjándékLista)
            {
                if (ajándék.GyártásiOrszág.Equals(ország, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(ajándék.Név);
                }
            }
        }

        public void MűhelyNyitás()
        {
            if (!MűhelyNyitva)
            {
                MűhelyNyitva = true;
                Console.WriteLine("A műhely nyitva van.");
            }
            else
            {
                Console.WriteLine("A műhely már nyitva van.");
            }
        }

        public void MűhelyBezárás()
        {
            if (MűhelyNyitva)
            {
                MűhelyNyitva = false;
                Console.WriteLine("A műhely bezárva.");
            }
            else
            {
                Console.WriteLine("A műhely már zárva van.");
            }
        }

        public void MűhelyVezetőMódosítás(string újVezető)
        {
            Műhelyvezető = újVezető;
            Console.WriteLine($"Az új műhelyvezető neve: {újVezető}");
        }

        public void AjándékTörlése(string név)
        {
            var ajándék = AjándékLista.Find(a => a.Név.Equals(név, StringComparison.OrdinalIgnoreCase));
            if (ajándék != null)
            {
                AjándékLista.Remove(ajándék);
                Console.WriteLine($"{név} törölve az ajándéklistáról.");
            }
            else
            {
                Console.WriteLine($"{név} nem található az ajándéklistán.");
            }
        }
    }
}

