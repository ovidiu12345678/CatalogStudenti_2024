using CatalogStudenti_2024;
using System;

class Program
{
    static void Main(string[] args)
    {
        var studenti = ObtinemStudenti();

        var studentiMajori = studenti.Where(s => s.Varsta > 20)
            .ToList();
        studentiMajori.ForEach(s => Console.WriteLine(s));

        var studentiGalati = studenti.Where(s => s.Adresa.NumeOras == "Galati" && s.Varsta > 20)
            .ToList();

        studentiGalati.ForEach(s => Console.WriteLine(s));

        var studentiIlfov = studenti.Where(s => s.Adresa.Judet == "Ilfov" && s.Note < 5)
            .ToList();

        studentiIlfov.ForEach(s => Console.WriteLine(s));

        var ordoneazaStudentiDupaOras = studenti.Where(s => s.Adresa.NumeOras == "Galati" && s.Adresa.NumeOras == "Oradea" && s.Varsta > 18)
            .OrderBy(s => s.Varsta)
            .ToList();

        ordoneazaStudentiDupaOras.ForEach(s => Console.Write(s));


        var numeTastatura = Console.ReadLine();

        var studentCautat = studenti.Where(s => s.Nume == numeTastatura);

        if(numeTastatura.Any())
        {
            Console.WriteLine("Studentul nu exista");
        }
        else
        {
            Console.WriteLine("Studentul exista");
        }

            

    }

    private static List<Student> ObtinemStudenti() =>
        new List<Student>()
        {
            new Student()
            {
              Nume = "Codreanu Amalia",
              Varsta = 21,
              Note = 10,
              Adresa = new Adresa()
              {
                  NumeOras = "Galati",
                  NumeStrada = "Blv. Galati",
                  NumarStrada = 9,
                  Judet = "Galati",
              },
            
            },

            new Student()
            {
                Nume = "Gabi",
                Varsta = 25,
                Note = 6,
                Adresa = new Adresa()
                {
                  NumeOras = "Iasi",
                  NumeStrada = "Blv. Iasi",
                  NumarStrada = 10,
                  Judet = "Iasi"
                }

            },

            new Student()
            {
                Nume = "Denisa",
                Varsta = 20,
                Note = 4,
                Adresa = new Adresa()
                {
                  NumeOras = "Pantelimon",
                  NumeStrada = "Strada Mihai Viteazu",
                  NumarStrada = 41,
                  Judet = "Ilfov",
                }
            },

            new Student()
            {
                Nume = "Patri",
                Varsta = 20,
                Note = 0,
                Adresa = new Adresa()
                {
                  NumeOras = "Oradea",
                  NumeStrada = "Str Rogerius",
                  NumarStrada = 3,
                  Judet = "Bihor",
                }
            },

            new Student()
            {
                Nume = "Alexandra",
                Varsta = 21,
                Note = 9,
                Adresa = new Adresa()
                {
                  NumeOras = "Galati",
                  NumeStrada = "Blv. Brailei",
                  NumarStrada = 11,
                  Judet = "Galati",
                }
            },

            new Student()
            {
                Nume = "Alehandro",
                Varsta = 20,
                Note = 4,
                Adresa = new Adresa()
                {
                  NumeOras = "Fagaras",
                  NumeStrada = "Blv. Fagaras",
                  NumarStrada = 9,
                  Judet = "Brasov",
                }
            }
        };
}