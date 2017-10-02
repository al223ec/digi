using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalent.Domain.DbEntities
{
    class Project
    {
        public int ID { get; set; }

        public int Name { get; set; }
        public DateTime StartDate { get; set; }

        public virtual ICollection<Consultant> Consulatants { get; set; }
    }
}
