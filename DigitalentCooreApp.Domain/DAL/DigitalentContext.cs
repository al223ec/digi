using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DigitalentCoreApp.Domain.DbEntities;

namespace DigitalentCoreApp.Domain.DAL
{
    public class DigitalentContext : DbContext
    {
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Project> Projects { get; set; }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<ConsultantSkill> ConsultantSkills { get; set; }
        public DbSet<Photo> Photos { get; set; }

        public DigitalentContext(DbContextOptions<DigitalentContext> options) 
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consultant>().ToTable("Consultant");
            modelBuilder.Entity<Assignment>().ToTable("Assignment");
            modelBuilder.Entity<Project>().ToTable("Project");

            modelBuilder.Entity<Skill>().ToTable("Skill");
            modelBuilder.Entity<ConsultantSkill>().ToTable("ConsultantSkill");
            modelBuilder.Entity<Photo>().ToTable("Photo");
        }
    }

}
