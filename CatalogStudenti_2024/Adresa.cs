using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogStudenti_2024
{
    internal class Adresa
    {
        public string NumeOras { get; set; }
        public string Judet { get; set; }
        public string NumeStrada { get; set; }
        public int NumarStrada { get; set; }

        public Adresa()
        {
            
        }

        public override string ToString() =>
            $"Nume Oras : {NumeOras}, Judet : {Judet}, Nume strada {NumeStrada} Numar Strada : {NumarStrada}";

    }
}
