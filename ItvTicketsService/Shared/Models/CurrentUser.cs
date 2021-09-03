using System;
using System.Collections.Generic;
using System.Text;

namespace ItvTicketsService.Shared.Models
{
    public class CurrentUser
    {
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public Dictionary<string, string> Claims { get; set; }
        public List<RoleType> Role { get; set; }
        public int PlantId { get; set; }
    }

    public enum RoleType
    {
        Admin = 1,
        Team = 2,
        Client = 3
    }
}
