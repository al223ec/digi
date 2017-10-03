using Digitalent.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitalentCoreApp.Domain.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DigitalentContext context)
        {
            // context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (context.Consultants.Any())
            {
                return;   // DB has been seeded
            }

            var consultants = new Consultant[]
            {
                new Consultant{FirstName="Carson", LastName="Alexander", Adress="Fräsplan 36", ZipCode="56 567", Phone="070 89772543", BirthDate=DateTime.Parse("1991-09-01")},
                new Consultant{FirstName="Meredith", LastName="Alonso", Adress="Stansvägen 45", ZipCode="129 39", Phone="070 843578345", BirthDate=DateTime.Parse("1985-07-19")},
                new Consultant{FirstName="Arturo", LastName="Anand", Adress="Klubbacken 34", ZipCode="435 09", Phone="070 8943578324", BirthDate=DateTime.Parse("1988-05-20")},
                new Consultant{FirstName="Gytis", LastName="Barzdukas", Adress="Idrottsparken 35", ZipCode="324 45", Phone="070 3247787", BirthDate=DateTime.Parse("1984-12-01")},
                new Consultant{FirstName="Yan", LastName="Li", Adress="Kaptenkläningsväg 85", ZipCode="454 66", Phone="070 8977787", BirthDate=DateTime.Parse("1986-11-11")},
                new Consultant{FirstName="Peggy", LastName="Justice", Adress="Jörnboda 1235", ZipCode="545 645", Phone="073 3123787", BirthDate=DateTime.Parse("1990-01-25")},
                new Consultant{FirstName="Laura", LastName="Norman", Adress="Björnvägen 23", ZipCode="45 566", Phone="070 89777467", BirthDate=DateTime.Parse("1981-05-12")},
                new Consultant{FirstName="Nino", LastName="Olivetto", Adress="Järnvägen 45", ZipCode="45 456", Phone="076 6554544", BirthDate=DateTime.Parse("1987-10-06")}
            };

            foreach (Consultant c in consultants)
            {
                context.Consultants.Add(c);
            }
            context.SaveChanges();


            var projects = new Project[]
            {
            new Project{ID=1050, Name="Ny hemsida åt järvpressen"},
            new Project{ID=4022, Name="Microeconomics"},
            new Project{ID=4041, Name="Macroeconomics"},
            new Project{ID=1045, Name="Calculus"},
            new Project{ID=3141, Name="Trigonometry"},
            new Project{ID=2021, Name="Composition"},
            new Project{ID=2042,Name="Literature"}
            };
            foreach (Project p in projects)
            {
                context.Projects.Add(p);
            }
            context.SaveChanges();

            var assignments = new Assignment[]
            {
            new Assignment{ConsultantID=1,ProjectID=1050, AssignmentType=AssignmentType.EXTERNAL},
            new Assignment{ConsultantID=1,ProjectID=4022, AssignmentType=AssignmentType.EXTERNAL},
            new Assignment{ConsultantID=1,ProjectID=4041, AssignmentType=AssignmentType.INTERNAL},
            new Assignment{ConsultantID=2,ProjectID=1045, AssignmentType=AssignmentType.EXTERNAL},
            new Assignment{ConsultantID=2,ProjectID=3141, AssignmentType =AssignmentType.INTERNAL},
            new Assignment{ConsultantID=2,ProjectID=2021, AssignmentType=AssignmentType.INTERNAL},
            new Assignment{ConsultantID=3,ProjectID=1050},
            new Assignment{ConsultantID=4,ProjectID=1050},
            new Assignment{ConsultantID=4,ProjectID=4022, AssignmentType=AssignmentType.INTERNAL},
            new Assignment{ConsultantID=5,ProjectID=4041, AssignmentType=AssignmentType.EXTERNAL},
            new Assignment{ConsultantID=6,ProjectID=1045},
            new Assignment{ConsultantID=7,ProjectID=3141, AssignmentType=AssignmentType.EXTERNAL},
            };
            foreach (Assignment a in assignments)
            {
                context.Assignments.Add(a);
            }
            context.SaveChanges();
        }
    }
}
