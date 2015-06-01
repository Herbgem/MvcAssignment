using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace MvcAssignment.Models
{
    public class SchoolContext:DbContext
    {
        public SchoolContext() : base("SchoolContextConnectionstring") { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasMany(c => c.Instructors).WithMany(i => i.Courses)
                .Map(t => t.MapLeftKey("CourseId").MapRightKey("InstructorId").ToTable("CourseInstructor"));

            modelBuilder.Entity<Course>().HasOptional(a => a.Instructors)
        }
    }
}