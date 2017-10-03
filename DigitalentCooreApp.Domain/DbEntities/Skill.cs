using DigitalentCoreApp.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalent.Domain.DbEntities
{
    public class Skill
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ConsultantSkill> ConsultantSkills { get; set; }
    }
}

