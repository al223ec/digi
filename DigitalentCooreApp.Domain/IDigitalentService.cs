using DigitalentCoreApp.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalentCoreApp.Domain
{
    public interface IDigitalentService
    {
        Task<Consultant> GetConsultants(string sortOrder, string currentFilter, string searchString, int? page, int pageSize);
    }
}
