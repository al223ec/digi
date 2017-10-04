using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DigitalentCoreApp.Domain.DbEntities
{
    public class Consultant
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }


        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }

        public string Phone { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<ConsultantSkill> ConsultantSkills { get; set; }
        
        public Photo Photo { get; set; }
    }
}
