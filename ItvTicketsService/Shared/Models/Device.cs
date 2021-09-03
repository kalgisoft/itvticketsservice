using System.ComponentModel.DataAnnotations;

namespace ItvTicketsService.Shared.Models
{
    public class Device
    {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }
        
        public string Type { get; set; }
        
        public string Info { get; set; }
        
        public int PlantId { get; set; }
        
        public int NumLinea { get; set; }

        [Required]
        public int IdContractor { get; set; }
    }
}
