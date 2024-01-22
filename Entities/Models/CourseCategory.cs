using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class CourseCategory : CoreEntity
    {
        
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}
