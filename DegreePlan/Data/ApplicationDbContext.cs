using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DegreePlan.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DBSet<Degree> Degrees { get; set; }
        public DBSet<Credit> Credits {get; set;}
        public DBSet<DegreeCredit> DegreeCredits {get; set;}
        public DBSet<DegreePlan> DegreePlans {get; set;}
        public DBSet<Student> Students {get; set;}
        public DBSet<Slot> Slots {get; set;}
        public DBSet<StudentTerm> StudentTerms {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Degree>().ToTable("Degree");
            modelBuilder.Entity<Credit>().ToTable("Credit");
            modelBuilder.Entity<DegreeCredit>().ToTable("DegreeCredit");
            modelBuilder.Entity<DegreePlan>().ToTable("Degreeplan");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Slot>().ToTable("Slot");
            modelBuilder.Entity<StudentTerm>().ToTable("StudentTerm");
        }
    }
}
