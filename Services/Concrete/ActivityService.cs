using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ActivityService : BaseService<Activity>, IActivityService
    {
        private ProjectContext _context;
        public ActivityService(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
