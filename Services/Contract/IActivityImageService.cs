using Entities.Models;
using Services.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contract
{
    public interface IActivityImageService : IService<ActivityImage> 
    {
        void SetFalse(List<ActivityImage> activityImages);
    }
}
