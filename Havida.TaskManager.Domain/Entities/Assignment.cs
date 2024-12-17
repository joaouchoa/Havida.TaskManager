using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havida.TaskManager.Domain.Entities
{
    public class Assignment
    {
        public Guid Id { get; set; } 
        public string Title { get; set; } 
        public string Description { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; 
        public DateTime? CompletedAt { get; set; } 


        public Guid UserId { get; set; }
        public User User { get; set; } 
    }
}
