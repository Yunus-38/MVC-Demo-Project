using Entities.Context;
using Entities.Models;
using Services.Base;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class LogoService : BaseService<Logo>, ILogoService
    {
        private ProjectContext _context;
        public LogoService(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
