using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CourseCategoryService : BaseService<CourseCategory>, ICourseCategoryService
    {
        private ProjectContext _context;
        public CourseCategoryService(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
