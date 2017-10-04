using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DigitalentCoreApp.Models;
using DigitalentCoreApp.Models.ConsultProjectViewModels;
using Microsoft.EntityFrameworkCore;
using DigitalentCoreApp.Domain.DAL;

namespace DigitalentCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DigitalentContext _context;

        public HomeController(DigitalentContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> About()
        {
            IQueryable<AssignmentGroup> data =

            from assignment in _context.Assignments
            group assignment by assignment.ProjectID into assignmentGroup
            select new AssignmentGroup()
            {
                ConsultantCount = assignmentGroup.Count(),
                Project = assignmentGroup.First().Project
            };

            return View(await data.AsNoTracking().ToListAsync()); 
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
