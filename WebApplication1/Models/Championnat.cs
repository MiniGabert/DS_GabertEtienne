using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers;

namespace WebApplication1.Models
{
    public class Championnat
    {
        public int Id { get; set; }
        public Tournoi Tournoi { get; set; }
        public Jeux jeux { get; set; }
        public String Nom { get; set; }
    }
}
