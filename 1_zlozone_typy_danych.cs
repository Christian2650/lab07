using System;

public class Program
{
    public enum DniTygodnia
    {
        Poniedzialek = 1,
        Wtorek,
        Sroda,
        Czwartek,
        Piatek,
        Sobota,
        Niedziela
    }
    public enum EtapyPrania
    {
        WstepnePlukanie = 1,
        GlownePranie,
        PlynDoPlukania,
        Suszenie
    }
    public enum Posilki
    {
        Sniadanie = 1,
        DrugieSniadanie,
        Obiad,
        Podwieczorek,
        Kolacja
    }

    public enum BierkiSzachowe
    {
        A1 = 1,
        B1,
        C1,
        D1,
        E1,
        F1,
        G1,
        H1,
        A2,
        B2,
        C2,
        D2,
        E2,
        F2,
        G2,
        H2,
    }

    public static void Main(string[] args)
    {
        // Przykład użycia typów wyliczeniowych

        DniTygodnia dzien1 = DniTygodnia.Poniedzialek;
        Console.WriteLine("Pierwszy dzień tygodnia: " + dzien1);

        EtapyPrania etap1 = EtapyPrania.WstepnePlukanie;
        Console.WriteLine("Pierwszy etap prania: " + etap1);

        Posilki posilek1 = Posilki.Sniadanie;
        Console.WriteLine("Pierwszy posiłek: " + posilek1);

        BierkiSzachowe bierka1 = BierkiSzachowe.A1;
        Console.WriteLine("Pierwsze biurko szachowe: " + bierka1);

        Console.ReadLine();
    }
}


