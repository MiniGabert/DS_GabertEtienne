using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Personne
    {
        public int Id { get; set; }
        public String Prenom { get; set; }
        public String Nom { get; set; }
        public String Pseudo { get; set; }
        public String Email { get; set; }
        public DateTime DatNaissance { get; set; }
        public Char Sexe { get; set; }
        public String Photo { get; set; }
    }
}
