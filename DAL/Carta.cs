using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Carta
    {
        [Key]
        public int IdCarta { get; set; }
        public string Cuerpo { get; set; }
        public int DestinatarioId { get; set; }
        public DateTime Fecha { get; set; }

        public Carta()
        {
            IdCarta = 0;
            Cuerpo = string.Empty;
            DestinatarioId = 0;
            Fecha = DateTime.Now;
        }
    }
    
}