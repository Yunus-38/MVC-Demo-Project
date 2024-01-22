using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ImageService : BaseService<Image>, IImageService
    {
        private ProjectContext _context;
        public ImageService(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
