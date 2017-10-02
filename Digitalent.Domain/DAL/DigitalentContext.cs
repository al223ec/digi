using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Digitalent.Domain.DbEntities
{
    class DigitalentContext : DbContext
    {
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Project> Projects { get; set; }

        public DigitalentContext(DbContextOptions<DigitalentContext> options) 
            : base(options)
        { }

      //  protected override void OnModelCreating(DbModelBuilder modelBuilder)
      //  {
      //       modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      //  }
   }

}
