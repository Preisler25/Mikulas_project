namespace Mikulas;
using System;

class Program
{
    static void Main()
    {
        // Tesztelés
        Ajándék ajándék1 = new Ajándék("Játékautó", 0.5, 2000, "Gyerek1", "Játék", false,
                                       "Gyártó1", 10, "Műanyag", DateTime.Now.AddMonths(1),
                                       false, "Magyarország", "Budapest", false);

        Ajándék ajándék2 = new Ajándék("Plüssmaci", 0.3, 1500, "Gyerek2", "Játék", false,
                                       "Gyártó2", 5, "Textil", DateTime.Now.AddMonths(2),
                                       true, "Kína", "Peking", false);

        MikulásMűhely műhely = new MikulásMűhely("Mikulás");

        műhely.AjándékHozzáadásaListához(ajándék1);
        műhely.AjándékHozzáadásaListához(ajándék2);

        műhely.BecsomagoltAjándékokMegjelenítése();
        műhely.LejártAjándékokEllenőrzése();
        műhely.TörékenyAjándékokEllenőrzése();
        műhely.EredetiOrszágbeliAjándékokMegjelenítése("Magyarország");

        műhely.MűhelyNyitás();
        műhely.MűhelyBezárás();
        műhely.MűhelyBezárás();

        műhely.MűhelyVezetőMódosítás("Új Mikulás");

        műhely.AjándékTörlése("Plüssmaci");

        Console.ReadLine();
    }
}
