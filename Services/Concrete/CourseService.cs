using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CourseService : BaseService<Course>, ICourseService
    {
        private ProjectContext _context;
        public CourseService(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
