using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DigitalentCoreApp.Domain.DbEntities
{
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // because of seed
        public int ID { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        public virtual ICollection<Consultant> Consulatants { get; set; }
    }
}
