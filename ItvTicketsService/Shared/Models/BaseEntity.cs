using System;
using System.Collections.Generic;
using System.Text;

namespace ItvTicketsService.Shared.Models
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
    }
}
