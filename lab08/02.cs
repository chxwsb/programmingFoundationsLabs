using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class MyProgram
{
    
    struct Student
    {
        public string nazwisko;
        public string adresZamieszkania;
        public DateTime dataUrodzenia;
        public int numerAlbumu;
        public string[] Kierunek;
        public bool czyZalegaZOplata;
        public Plec plec;
        public string adresEmail;
        public int numerTelefonu;

        public enum Plec
        {
            Kobieta,
            Mezczyzna
        }
    }

    struct Przedmiot
    {
        public string nazwa;
        public bool czyObowiazkowy;
        public int iloscECTS;
        public string[] kierunki;
        public int iloscGodzin;
        public int iloscSemestrow;
        public int stopienStudiow;
    }

    struct NauczycielAkademicki
    {
        public string[] imie;
        public string[] nazwisko;
        public int numerKontaDoPrzelewow;
        public int numerPesel;
        public string adresZamieszkania;
        public string adresEmail;
        public string[] prowadzonePrzedmioty;

    }

    public static void Main(string[] args)
    {

    }

}