using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Logo : CoreEntity
    {
        
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
