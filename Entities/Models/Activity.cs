using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Activity : CoreEntity
    {
        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual ActivityCategory Category { get; set; }
        public virtual ICollection<ActivityImage> Images { get; set; }
    }
}
