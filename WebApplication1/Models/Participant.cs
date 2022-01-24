using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public Personne Personne1 { get; set; }
        public Personne Personne2 { get; set; }
        public Championnat Championnat { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public DateTime DateDebut{ get; set; }
    }
}
