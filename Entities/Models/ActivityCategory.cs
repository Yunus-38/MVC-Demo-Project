using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class ActivityCategory : CoreEntity
    {
        
        public string Name { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
    }
}
