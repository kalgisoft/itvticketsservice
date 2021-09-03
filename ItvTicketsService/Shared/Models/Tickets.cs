using System;
using System.ComponentModel.DataAnnotations;

namespace ItvTicketsService.Shared.Models
{
    public class Tickets
    {
        public int TicketId { get; set; }

        //data creazione ticket da utente client
        public DateTime CreatedDate { get; set; }

        //data inizio intervento da utente team
        public DateTime OpenDate { get; set; }

        //data fine intevento confermata da utente client
        public DateTime CloseDate { get; set; }

        //motivo intervento
        [Required]
        public string Reason { get; set; }

        public int TicketStatusId { get; set; }

        public string TicketStatus { get; set; }

        //[Required]
        //public int PlantId { get; set; }

        //sistema su cui effettuare intervento
        [Required]
        public int DeviceId { get; set; }

        //id dello user client che ha richiesto il ticket, determina anche il PlantID
        [Required]
        public int ClientId { get; set; }

        //id dello user team che gestisce il ticket
        public int TeamId { get; set; }

        //commenti del team relativi al lavoro svolto
        public string TeamMemo { get; set; }

        //id dello user client o team che chiude il ticket
        public int CloserId { get; set; }
    }

    public class TicketStatusModel
    {
        public int TicketStatusId { get; set; }

        public string TicketStatus { get; set; }
    }
}
