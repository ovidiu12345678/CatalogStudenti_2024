using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogStudenti_2024
{
    internal class Student
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public int Varsta { get; set; }
        public int Note { get; set; }

        public Adresa Adresa { get; set; }

        public Student()
        {
            this.Id = Guid.NewGuid();
        }

        public override string ToString() =>
            $"Id : {Id}, Nume : {Nume}, Adresa : {Adresa}, Varsta : {Varsta}, Note :{Note} ";
        
    }
}
