using Digitalent.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalentCoreApp.Domain.DbEntities
{
    public class ConsultantSkill
    {
        public int ID { get; set; } 
        public int ConsultantID { get; set; }
        public int SkillID { get; set; }


        public virtual Skill Skill { get; set; }
        public virtual Consultant Consultant { get; set; }
    }
}
