using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public Championnat Championnat { get; set; }
        public Personne Personne { get; set; }

        public String Equipe { get; set; }
    }
}
