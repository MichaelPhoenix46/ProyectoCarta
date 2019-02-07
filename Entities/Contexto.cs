using Entities;
using System.Data.Entity;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Carta> Carta { get; set; }
        public DbSet<Destinatario> Destinatario { get; set; }

        public Contexto() : base("ConStr")
        {
        }
    }
}
