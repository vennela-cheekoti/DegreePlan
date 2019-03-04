using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DegreePlan.Models;

namespace DegreePlan.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Credit> Credits {get; set;}
        public DbSet<DegreeCredit> DegreeCredits {get; set;}
        public DbSet<Degreeplan> DegreePlans {get; set;}
        public DbSet<Student> Students {get; set;}
        public DbSet<Slot> Slots {get; set;}
        public DbSet<StudentTerm> StudentTerms {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Degree>().ToTable("Degree");
            modelBuilder.Entity<Credit>().ToTable("Credit");
            modelBuilder.Entity<DegreeCredit>().ToTable("DegreeCredit");
            modelBuilder.Entity<Degreeplan>().ToTable("Degreeplan");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Slot>().ToTable("Slot");
            modelBuilder.Entity<StudentTerm>().ToTable("StudentTerm");
        }
    }
}
