
namespace ItvTicketsService.Shared.Models
{
    public class Plant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int IdCompany { get; set; }
    }
}
