using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.klasa
{
    class Student
    {

        public Student()
        {

        }

        int indeks ;
        double ocena1;
        double ocena2;
        double ocena3;
        public void DodajStudenta()
        {
 
            Console.WriteLine("Podaj numer indeksu");
            indeks = Console.Read();
            Console.WriteLine("Podaj ocene z przedmiotu pierwszego");
            ocena1 = Console.Read();
            Console.WriteLine("Podaj ocene z przedmiotu drugiego");
            ocena2 = Console.Read();
            Console.WriteLine("Podaj ocene z przedmiotu trzeciego");
            ocena3 = Console.Read();
            var sum = ocena1 + ocena2 + ocena3;
            var avg = sum / 3;
            Console.WriteLine("Twoja średnia z ocen to:" + avg);
            Console.ReadLine();
        }

    }
}

