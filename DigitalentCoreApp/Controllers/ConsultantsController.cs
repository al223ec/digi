using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Digitalent.Domain.DbEntities;

namespace DigitalentCoreApp.Controllers
{
    public class ConsultantsController : Controller
    {
        private readonly DigitalentContext _context;

        public ConsultantsController(DigitalentContext context)
        {
            _context = context;
        }

        // GET: Consultants
    //        synchronous programming is the default mode for ASP.NET Core and EF Core.
    //        A web server has a limited number of threads available, and in high load situations all of the available threads might be in use.When that 
    //        happens, the server can't process new requests until the threads are freed up. With synchronous code, many threads may be tied 
    //        up while they aren't actually doing any work because they're waiting for I/O to complete. With asynchronous code, when a process 
    //        is waiting for I/O to complete, its thread is freed up for the server to use for processing other requests. As a result, asynchronous
    //        code enables server resources to be used more efficiently, and the server is enabled to handle more traffic without delays.
    //        Asynchronous code does introduce a small amount of overhead at run time, but for low traffic situations the performance hit is negligible, 
    //        while for high traffic situations, the potential performance improvement is substantial.
    //      In the following code, the async keyword, Task<T> return value, await keyword, and ToListAsync method make the code execute asynchronously.
        public async Task<IActionResult> Index(
                string sortOrder,
                string currentFilter,
                string searchString,
                int? page)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CurrentFilter"] = searchString;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }


            var consultants = from c in _context.Consultants
                           select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                consultants = consultants.Where(c => c.LastName.Contains(searchString)
                                       || c.FirstName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    consultants = consultants.OrderByDescending(c => c.LastName);
                    break;
                default:
                    consultants = consultants.OrderBy(c => c.LastName);
                    break;
            }

            int pageSize = 3;
            return View(await PaginatedList<Consultant>.CreateAsync(consultants.AsNoTracking(), page ?? 1, pageSize));// query to list
        }

        // GET: Consultants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultant = await _context.Consultants
                .Include(c => c.Assignments)
                .ThenInclude(a => a.Project)
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.ID == id);
  
            if (consultant == null)
            {
                return NotFound();
            }

            return View(consultant);
        }

        // GET: Consultants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Consultants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,BirthDate,Phone,Adress,ZipCode")] Consultant consultant)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(consultant);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(consultant);
        }

        // GET: Consultants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultant = await _context.Consultants.SingleOrDefaultAsync(m => m.ID == id);
            if (consultant == null)
            {
                return NotFound();
            }
            return View(consultant);
        }

        // POST: Consultants/Edit/5
        // implement a security best practice to prevent overposting. No bind
        
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultantToUpdate = await _context.Consultants.SingleOrDefaultAsync(c => c.ID == id);
            if (await TryUpdateModelAsync<Consultant>(
                consultantToUpdate,
                "",
                c => c.FirstName, c => c.LastName, c => c.BirthDate, c => c.Phone, c => c.Adress, c => c.ZipCode))
            {
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }

            return View(consultantToUpdate);
        }

        // GET: Consultants/Delete/5
        // an optional parameter that indicates whether the method was called after a failure to save changes.
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultant = await _context.Consultants
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.ID == id);
            if (consultant == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(consultant);
        }

        // POST: Consultants/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consultant = await _context.Consultants
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.ID == id);
            if (consultant == null)
            {
                return RedirectToAction(nameof(Index));
            }
            try
            {
                _context.Consultants.Remove(consultant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool ConsultantExists(int id)
        {
            return _context.Consultants.Any(e => e.ID == id);
        }
    }
}
