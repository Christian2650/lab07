using System;

public enum Plec
{
    Kobieta,
    Mezczyzna
}

public struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public double Ocena;
    public Plec Plec;
}

public class Program
{
    public static void WypelnijStudenta(ref Student student)
    {
        Console.WriteLine("Podaj nazwisko studenta:");
        student.Nazwisko = Console.ReadLine();

        Console.WriteLine("Podaj numer albumu:");
        int nrAlbumu;
        while (!int.TryParse(Console.ReadLine(), out nrAlbumu))
        {
            Console.WriteLine("Niepoprawny numer albumu. Podaj ponownie:");
        }
        student.NrAlbumu = nrAlbumu;

        Console.WriteLine("Podaj ocenę (od 2.0 do 5.0):");
        double ocena;
        while (!double.TryParse(Console.ReadLine(), out ocena) || ocena < 2.0 || ocena > 5.0)
        {
            Console.WriteLine("Niepoprawna ocena. Podaj ponownie:");
        }
        student.Ocena = ocena;

        Console.WriteLine("Podaj płeć studenta (0 - Kobieta, 1 - Mężczyzna):");
        int plec;
        while (!int.TryParse(Console.ReadLine(), out plec) || plec < 0 || plec > 1)
        {
            Console.WriteLine("Niepoprawna wartość. Podaj ponownie:");
        }
        student.Plec = (Plec)plec;
    }

    public static double ObliczSrednia(Student[] grupa)
    {
        double sumaOcen = 0;
        foreach (var student in grupa)
        {
            sumaOcen += student.Ocena;
        }
        return sumaOcen / grupa.Length;
    }

    public static void WyswietlStudenta(Student student)
    {
        string plec = student.Plec == Plec.Kobieta ? "Kobieta" : "Mężczyzna";
        Console.WriteLine($"Nazwisko: {student.Nazwisko}, Numer albumu: {student.NrAlbumu}, Ocena: {student.Ocena}, Płeć: {plec}");
    }

    public static void Main(string[] args)
    {
        Student[] grupa = new Student[5];

        Console.WriteLine("Wprowadź dane dla 5 studentów:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Student {i + 1}:");
            WypelnijStudenta(ref grupa[i]);
            Console.WriteLine();
        }

        Console.WriteLine("Dane studentów:");
        foreach (var student in grupa)
        {
            WyswietlStudenta(student);
        }

        double srednia = ObliczSrednia(grupa);
        Console.WriteLine($"Średnia ocen: {srednia}");

        Console.ReadLine();
    }
}
