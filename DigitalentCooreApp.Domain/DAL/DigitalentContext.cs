using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Digitalent.Domain.DbEntities
{
    public class DigitalentContext : DbContext
    {
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Project> Projects { get; set; }

        public DigitalentContext(DbContextOptions<DigitalentContext> options) 
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consultant>().ToTable("Consultant");
            modelBuilder.Entity<Assignment>().ToTable("Assignment");
            modelBuilder.Entity<Project>().ToTable("Project");
        }
    }

}
