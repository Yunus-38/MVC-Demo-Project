using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Image : CoreEntity
    {
        public Image()
        {
            IsActive = false;
        }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

    }
}
