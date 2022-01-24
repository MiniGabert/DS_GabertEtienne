using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
namespace WebApplication1.Models
{
    public class Organisation
    {
        public int Id { get; set; }

        public Poste Poste { get; set; }

        public Tournoi Tournois { get; set; }

        public Personne Personne { get; set; }
    }
}
