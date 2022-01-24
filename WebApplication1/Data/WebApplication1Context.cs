using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using DS_GabertEtienne.Models;

namespace WebApplication1.Data
{
    public class WebApplication1Context : DbContext
    {
        public WebApplication1Context (DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Tournoi> Tournoi { get; set; }

        public DbSet<WebApplication1.Models.Poste> Poste { get; set; }

        public DbSet<WebApplication1.Models.Personne> Personne { get; set; }

        public DbSet<WebApplication1.Models.Jeux> Jeux { get; set; }

        public DbSet<WebApplication1.Models.Organisation> Organisation { get; set; }

        public DbSet<WebApplication1.Models.Championnat> Championnat { get; set; }

        public DbSet<WebApplication1.Models.Participant> Participant { get; set; }

        public DbSet<DS_GabertEtienne.Models.Resultat> Resulat { get; set; }
    }
}
