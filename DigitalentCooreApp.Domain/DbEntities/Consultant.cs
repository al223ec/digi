using DigitalentCoreApp.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalent.Domain.DbEntities
{
    public class Consultant
    {
        public int ID { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<ConsultantSkill> ConsultantSkills { get; set; }

        public virtual Photo Photo { get; set; }
    }
}
