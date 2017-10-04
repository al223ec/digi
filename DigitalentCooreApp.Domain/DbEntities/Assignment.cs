using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigitalentCoreApp.Domain.DbEntities
{
    public enum AssignmentType
    {
        EXTERNAL, INTERNAL, FULLTIME
    }

    public class Assignment
    {
        public int ID { get; set; }
        public int ConsultantID { get; set; }
        public int ProjectID { get; set; }

        public AssignmentType? AssignmentType { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AssignmentDate { get; set; }

        public virtual Project Project { get; set; }
        public virtual Consultant Consultant { get; set; }
    }
}
