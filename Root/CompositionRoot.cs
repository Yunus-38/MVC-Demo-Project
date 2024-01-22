using Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Root
{
    public class CompositionRoot
    {
        public static void InjectDependencies(IServiceCollection services)
        {
            services.AddScoped<ProjectContext>();
            services.AddScoped(typeof(IActivityCategoryService), typeof(ActivityCategoryService));
            services.AddScoped(typeof(IActivityImageService), typeof(ActivityImageService));
            services.AddScoped(typeof(IActivityService), typeof(ActivityService));
            services.AddScoped(typeof(ICourseCategoryService), typeof(CourseCategoryService));
            services.AddScoped(typeof(ICourseService), typeof(CourseService));
            services.AddScoped(typeof(IImageService), typeof(ImageService));
            services.AddScoped(typeof(ILogoService), typeof(LogoService));

            services.AddDbContext<ProjectContext>(options => options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BDT;Trusted_Connection=true", x => x.MigrationsAssembly("UI")));
        }
    }
}
