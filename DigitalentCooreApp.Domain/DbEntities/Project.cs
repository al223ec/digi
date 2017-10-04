using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalentCoreApp.Domain.DbEntities
{
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // because of seed
        public int ID { get; set; }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public virtual ICollection<Consultant> Consulatants { get; set; }
    }
}
