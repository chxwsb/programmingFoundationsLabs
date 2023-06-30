using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

public class MyProgram
{
    
    public struct Student
    {
        public string nazwisko;
        public int numerAlbumu;
        public double ocena;
        public Plec plec;

        public enum Plec
        {
            Kobieta,
            Mezczyzna
        }
    }

    public static void uzupelnijPola(ref Student student, string nazwisko, int numerAlbumu, double ocena, int plec)
    {
        student.nazwisko = nazwisko;
        student.numerAlbumu = numerAlbumu;

        student.ocena = ocena;
        if (student.ocena < 2)
        {
            student.ocena = 2;
        } else if (student.ocena > 5)
        {
            student.ocena = 5;
        }

        int czyKobieta = plec;
        if (czyKobieta == 1)
        {
            student.plec = Student.Plec.Kobieta;
        } else if (czyKobieta == 2)
        {
            student.plec = Student.Plec.Mezczyzna;
        }
    }

    public static void wypiszStudentow(Student[] bazaStudentow)
    {
        for (int i = 0; i < bazaStudentow.Length; i++)
        {
            Console.WriteLine("Dane studenta nr {0,-8} Nazwisko: {1, -16} Numer albumu: {2, -8} Ocena: {3,-8} Plec: {4,-8}", i+1, bazaStudentow[i].nazwisko, bazaStudentow[i].numerAlbumu, bazaStudentow[i].ocena, bazaStudentow[i].plec);
        }
    }

    public static void policzSrednia(Student[] bazaStudentow)
    {
        double suma = 0;
        for (int i = 0; i < bazaStudentow.Length; i++)
        {
            suma += bazaStudentow[i].ocena;
        }

        double srednia = suma / bazaStudentow.Length;

        Console.WriteLine("Srednia ocen studentow to: {0}", srednia);
    }

    public static void Main(string[] args)
    {        
        List<Student> bazaStudentow = new List<Student>();
        
        Student student1 = new Student();
        uzupelnijPola(ref student1, "Student", 11111, 3, 2);
        bazaStudentow.Add(student1);
        Student student2 = new Student();
        uzupelnijPola(ref student2, "Uczen", 22222, 4, 2);
        bazaStudentow.Add(student2);
        Student student3 = new Student();
        uzupelnijPola(ref student3, "Janda", 33333, 5, 1);
        bazaStudentow.Add(student3);
        Student student4 = new Student();
        uzupelnijPola(ref student4, "Banda", 44444, -100, 1);
        bazaStudentow.Add(student4);
        Student student5 = new Student();
        uzupelnijPola(ref student5, "Wanda", 55555, 100, 1);
        bazaStudentow.Add(student5);

        wypiszStudentow(bazaStudentow.ToArray());

        policzSrednia(bazaStudentow.ToArray());
    }

    //Potencjalne funkcje do wykorzystania w przypadku checi przeksztalcenia programu taka by mozna bylo pobierac dane od uzytkownika
    public static string pobierzString()
    {
        string tekst = Console.ReadLine();
        return tekst;
    }

    public static int pobierzInt()
    {
        string ciagZnakow = Console.ReadLine();
        int liczbaCalkowita;
        int.TryParse(ciagZnakow, out liczbaCalkowita);
        return liczbaCalkowita;
    }

    public static double pobierzDouble()
    {
        string ciagZnakow = Console.ReadLine();
        double liczbaZmiennoprzecinkowa;
        double.TryParse(ciagZnakow, out liczbaZmiennoprzecinkowa);
        return liczbaZmiennoprzecinkowa;
    }

    public static bool pobierzBoolean()
    {
        string ciagZnakow = Console.ReadLine();
        bool wartoscBoolean;
        bool.TryParse(ciagZnakow, out wartoscBoolean);
        return wartoscBoolean;
    }

}