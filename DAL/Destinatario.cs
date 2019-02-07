using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Destinatario
    {
        [Key]
        public int DestinatarioId { get; set; }
        public string Nombre { get; set; }
        public int CantidadCartas { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Destinatario()
        {
            DestinatarioId = 0;
            Nombre = string.Empty;
            CantidadCartas = 0;
            FechaRegistro = DateTime.Now;
        }
    }
}
