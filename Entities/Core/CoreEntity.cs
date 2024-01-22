using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Core
{
    public class CoreEntity
    {
        public CoreEntity()
        {
            this.Id = Id++;

            this.CreatedDate = DateTime.Now;

            this.IsDeleted = 0;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int IsDeleted { get; set; }
        

    }
}
