using System;

public class Program
{
    public struct Student
    {
        public string Imie;
        public string Nazwisko;
        public int NumerIndeksu;
    }
    public struct Przedmiot
    {
        public string Nazwa;
        public string Kierunek;
        public int Semestr;
    }
    public struct NauczycielAkademicki
    {
        public string Imie;
        public string Nazwisko;
        public string TytulNaukowy;
        public string Przedmiot;
    }

    public static void Main(string[] args)
    {
        // Przykład użycia struktur

        Student student1 = new Student();
        student1.Imie = "Jan";
        student1.Nazwisko = "Kowalski";
        student1.NumerIndeksu = 12345;

        Przedmiot przedmiot1 = new Przedmiot();
        przedmiot1.Nazwa = "Programowanie";
        przedmiot1.Kierunek = "Informatyka";
        przedmiot1.Semestr = 3;

        NauczycielAkademicki nauczyciel1 = new NauczycielAkademicki();
        nauczyciel1.Imie = "Anna";
        nauczyciel1.Nazwisko = "Nowak";
        nauczyciel1.TytulNaukowy = "dr";
        nauczyciel1.Przedmiot = "Programowanie";

        Console.WriteLine("Student:");
        Console.WriteLine("Imię: " + student1.Imie);
        Console.WriteLine("Nazwisko: " + student1.Nazwisko);
        Console.WriteLine("Numer indeksu: " + student1.NumerIndeksu);

        Console.WriteLine();

        Console.WriteLine("Przedmiot:");
        Console.WriteLine("Nazwa: " + przedmiot1.Nazwa);
        Console.WriteLine("Kierunek: " + przedmiot1.Kierunek);
        Console.WriteLine("Semestr: " + przedmiot1.Semestr);

        Console.WriteLine();

        Console.WriteLine("Nauczyciel akademicki:");
        Console.WriteLine("Imię: " + nauczyciel1.Imie);
        Console.WriteLine("Nazwisko: " + nauczyciel1.Nazwisko);
        Console.WriteLine("Tytuł naukowy: " + nauczyciel1.TytulNaukowy);
        Console.WriteLine("Przedmiot: " + nauczyciel1.Przedmiot);

        Console.ReadLine();
    }
}

