using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ActivityCategoryService : BaseService<ActivityCategory>, IActivityCategoryService
    {
        private ProjectContext _context;
        public ActivityCategoryService(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
