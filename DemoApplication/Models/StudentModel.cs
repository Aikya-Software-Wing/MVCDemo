namespace DemoApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentModel : DbContext
    {
        public StudentModel()
            : base("name=StudentModel")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Mark> Marks { get; set; }
    }

}