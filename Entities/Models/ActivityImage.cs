using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class ActivityImage : CoreEntity
    {
        public ActivityImage()
        {
            IsActive = false;
        }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }

    }
}
