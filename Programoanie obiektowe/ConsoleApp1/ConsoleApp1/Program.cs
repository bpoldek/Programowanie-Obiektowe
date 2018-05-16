using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        string indeks;
        string imie;
        string nazwisko;
        string ocena1;
        string ocena2;
        string ocena3;
        string ocena4;


        public void WyswietlStudenta(string indeks, string imie)
        {
        
            this.imie = imie;
            this.indeks = indeks;
            Console.WriteLine(indeks);
            Console.WriteLine(imie);
        }
        public void DodajStudenta(string indeks = "", string imie = "", string nazwisko = "", string ocena1 = "", string ocena2 = "", string ocena3 = "", string ocena4 = "")
        {
            this.imie = imie;
            this.indeks = indeks;
            this.nazwisko = nazwisko;
            this.ocena1 = ocena1;
            this.ocena2 = ocena2;
            this.ocena3 = ocena3;
            this.ocena4 = ocena4;

        }
        public Student(string indeks = "", string imie = "", string nazwisko = "", string ocena1 = "", string ocena2 = "", string ocena3 = "", string ocena4 = "")
        {
            Console.WriteLine("Wybrano opcję twrzenia studenta ");
            Console.WriteLine("Podaj imię studenta: ");
            imie = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Podaj nazwisko studenta: ");
            nazwisko = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Podaj indeks studenta: ");
            indeks = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Podaj pierwsza ocene studenta: ");
            ocena1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Podaj drugą ocenę studenta: ");
            ocena2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Podaj trzecia ocene studenta");
            ocena3 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Podaj czwartą ocene studenta:");
            ocena4 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Dodano studenta " + imie + " " + nazwisko + " o numerze inkedksu " + indeks + ", jego oceny to " + ocena1 + ", " + ocena2 + ", " + ocena3 + ", " + ocena4 );
            Console.ReadLine();
            Console.Clear();
        }

    }
    class Grupa
    {
        string NazwaKursu;
        string dzien;
        string godzina;
        string tydzien;

        public void DodajGrupe(string NazwaKursu = "", string dzien = "", string godzina = "", string tydzien = "")
        {
            this.NazwaKursu = NazwaKursu;
            this.dzien = dzien;
            this.godzina = godzina;
            this.tydzien = tydzien;
        }
        public Grupa(string NazwaKursu = "", string dzien = "", string godzina = "", string tydzien = "")
        {
            Console.WriteLine("Wybrano opcję tworzenia grupy");
            Console.WriteLine("Nazwa kursu: ");
            NazwaKursu = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Wybierz dzień tygodnia w którym odbywają się zajęcia:");
            Console.WriteLine("a - Poniedziałek");
            Console.WriteLine("b - Wtorek ");
            Console.WriteLine("c - Środa");
            Console.WriteLine("d - Czwartek");
            Console.WriteLine("e - Piątek");
            dzien = Console.ReadLine();
            switch (dzien)
            {
                case "a": dzien = "Poniedziałek"; break;
                case "b": dzien = "Wtorek"; break;
                case "c": dzien = "Środa"; break;
                case "d": dzien = "Czwartek"; break;
                case "e": dzien = "Piątek"; break;
                default: Console.WriteLine("Wybierz literę od a do e "); break;
            }
            Console.Clear();
            Console.WriteLine("Wybierz godzinę w której odbywają się zajęcia:");
            Console.WriteLine("a - 7:30");
            Console.WriteLine("b - 9:15 ");
            Console.WriteLine("c - 11:15");
            Console.WriteLine("d - 13:15");
            Console.WriteLine("e - 15:15");
            Console.WriteLine("f - 17:05");
            Console.WriteLine("g - 18:55");
            godzina = Console.ReadLine();
            switch (godzina)
            {
                case "a": godzina = "7:30"; break;
                case "b": godzina = "9:15"; break;
                case "c": godzina = "11:15"; break;
                case "d": godzina = "13:15"; break;
                case "e": godzina = "15:15"; break;
                case "f": godzina = "17:05"; break;
                case "g": godzina = "18:55"; break;
                default: Console.WriteLine("Wybierz literę od a do g "); break;
            }
            Console.Clear();
            Console.WriteLine("Wybierz tydzień w którym odbywają się zajęcia:");
            Console.WriteLine("a - Tydzień nieparzysty");
            Console.WriteLine("b - Tydzień parzysty");
            Console.WriteLine("c - Co tydzień");
            tydzien = Console.ReadLine();
            switch(tydzien)
            {
                case "a": tydzien = "nieparzystym"; break;
                case "b": tydzien = "parzystym"; break;
                case "c": tydzien = "co tydzień"; break;
            }
            Console.Clear();
            Console.WriteLine("Dodano grupe kursu " + NazwaKursu + " w dniu: " + dzien + " o godzinie " + godzina + " w tygodniu: " + tydzien);
            Console.ReadLine();
            Console.Clear();
        }

    }
}
    class Program
    {



        static void Main(string[] args)
        {
            
            for (; ;)
            {
                Console.WriteLine("___Menu___");
                Console.WriteLine("1 - Utworz Grupe");
                Console.WriteLine("2 - Utworz Studenta");
                Console.WriteLine("3 - Wyświetl Grupe");
                Console.WriteLine("4 - Wyświetl Studenta");
                Console.WriteLine("5 - Wyjdź");
                string wybor = Console.ReadLine();
                Console.Clear();
                switch (wybor)
                {
                    case "1": Grupa NowaGrupa = new Grupa();
                              NowaGrupa.DodajGrupe();
                    break;


                    case "2": Student NowyStudent = new Student();
                                      NowyStudent.DodajStudenta();
                    break;


                    case "3": Console.WriteLine("wybrano 3"); break;
                        ;
                    case "4": Student NowyStudent2 = new Student();
                              NowyStudent2.WyswietlStudenta("230241", "Bartlomiej");
                        break;
                    case "5": Environment.Exit(1); break;
                    default: Console.WriteLine("Proszę wybrać odpowiednią liczbę od 1 do 5"); break;

                }
            }

        }
    }

