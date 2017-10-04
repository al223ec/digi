using DigitalentCoreApp.Domain.DAL;
using DigitalentCoreApp.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalentCoreApp.Domain
{
    public class DigitalentService : IDigitalentService
    {
        private DigitalentContext _context; 

        public DigitalentService(DigitalentContext context)
        {
            _context = context;
        }

        public Task<Consultant> GetConsultants(string sortOrder, string currentFilter, string searchString, int? page, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
