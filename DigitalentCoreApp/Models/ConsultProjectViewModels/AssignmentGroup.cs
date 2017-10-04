using DigitalentCoreApp.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalentCoreApp.Models.ConsultProjectViewModels
{
    public class AssignmentGroup
    {
        public int ConsultantCount { get; set; }
        public Project Project { get; set; }

    }
}
