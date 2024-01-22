using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Context
{
    public class ProjectContext : IdentityDbContext<User>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<ActivityCategory> ActivityCategories { get; set; }
        public virtual DbSet<ActivityImage> ActivityImages { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseCategory> CourseCategories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Logo> Logos { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
