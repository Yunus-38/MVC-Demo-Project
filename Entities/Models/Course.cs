using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Course : CoreEntity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual CourseCategory Category { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
