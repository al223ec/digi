using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalent.Domain.DbEntities
{
    public enum AssignmentType
    {
        EXTERNAL, INTERNAL
    }

    public class Assignment
    {
        public int ID { get; set; }
        public int ConsultantID { get; set; }
        public int ProjectID { get; set; }

        public AssignmentType? AssignmentType { get; set; }

        public DateTime AssignmentDate { get; set; }

        public virtual Project Project { get; set; }
        public virtual Consultant Consultant { get; set; }
    }
}
