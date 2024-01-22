using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ActivityImageService : BaseService<ActivityImage>, IActivityImageService
    {
        private ProjectContext _context;
        public ActivityImageService(ProjectContext context) : base(context)
        {
            _context = context;
        }

        public void SetFalse(List<ActivityImage> activityImages)
        {
            foreach (ActivityImage activityImage in activityImages)
            {
                activityImage.IsActive = false;
                Update(activityImage);
            }
            Save();
        }
    }
}
