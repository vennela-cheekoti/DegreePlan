using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DegreePlan.Data;
using DegreePlan.Models;

namespace DegreePlan.Controllers
{
    public class DegreeplansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DegreeplansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Degreeplans
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
           // var applicationDbContext = _context.DegreePlans.Include(d => d.Degree).Include(d => d.Student);
            ViewData["StudentidSortParm"] = sortOrder == "Studentid" ? "Studentid_desc" : "Studentid";
            ViewData["DegreePlanAbvSortParm"] = String.IsNullOrEmpty(sortOrder) ? "DegreeplanAbv_desc" : "";
            ViewData["DegreePlanNameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "DegreePlanName_desc" : "";
            ViewData["DegreeidSortParm"] = sortOrder == "Degreesid" ? "Degreeid_desc" : "Degreeid";
            ViewData["CurrentFilter"] = searchString;
            var degreeplans = from s in _context.DegreePlans
                              select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                degreeplans = degreeplans.Where(s => s.DegreePlanAbv.Contains(searchString)
                                       || s.DegreePlanName.Contains(searchString)||s.StudentId.ToString().Contains(searchString)||s.DegreeId.ToString().Contains(searchString));
            }
            switch (sortOrder)
            {
                case "Studentid_desc":
                    degreeplans = degreeplans.OrderByDescending(s => s.StudentId);
                    break;
                case "Studentid":
                    degreeplans = degreeplans.OrderBy(s => s.StudentId);
                    break;
                case "DegreeplanAbv_desc":
                    degreeplans = degreeplans.OrderBy(s => s.DegreePlanAbv);
                    break;
                case "DegreePlanName_desc":
                    degreeplans = degreeplans.OrderBy(s => s.DegreePlanName);
                    break;
                case "Degreeid_desc":
                    degreeplans = degreeplans.OrderByDescending(s => s.DegreeId);
                    break;
                case "Degreeid":
                    degreeplans = degreeplans.OrderBy(s => s.DegreeId);
                    break;
                default:
                    degreeplans = degreeplans.OrderBy(s => s.DegreeplanId);
                    break;
            }
            return View(await degreeplans.AsNoTracking().ToListAsync());
        }

        // GET: Degreeplans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeplan = await _context.DegreePlans
                .Include(d => d.Degree)
                .Include(d => d.Student)
                .FirstOrDefaultAsync(m => m.DegreeplanId == id);
            if (degreeplan == null)
            {
                return NotFound();
            }

            return View(degreeplan);
        }

        // GET: Degreeplans/Create
        public IActionResult Create()
        {
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId");
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId");
            return View();
        }

        // POST: Degreeplans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DegreeplanId,StudentId,DegreePlanAbv,DegreePlanName,DegreeId")] Degreeplan degreeplan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(degreeplan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", degreeplan.DegreeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", degreeplan.StudentId);
            return View(degreeplan);
        }

        // GET: Degreeplans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeplan = await _context.DegreePlans.FindAsync(id);
            if (degreeplan == null)
            {
                return NotFound();
            }
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", degreeplan.DegreeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", degreeplan.StudentId);
            return View(degreeplan);
        }

        // POST: Degreeplans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DegreeplanId,StudentId,DegreePlanAbv,DegreePlanName,DegreeId")] Degreeplan degreeplan)
        {
            if (id != degreeplan.DegreeplanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(degreeplan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DegreeplanExists(degreeplan.DegreeplanId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeId", degreeplan.DegreeId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", degreeplan.StudentId);
            return View(degreeplan);
        }

        // GET: Degreeplans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeplan = await _context.DegreePlans
                .Include(d => d.Degree)
                .Include(d => d.Student)
                .FirstOrDefaultAsync(m => m.DegreeplanId == id);
            if (degreeplan == null)
            {
                return NotFound();
            }

            return View(degreeplan);
        }

        // POST: Degreeplans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var degreeplan = await _context.DegreePlans.FindAsync(id);
            _context.DegreePlans.Remove(degreeplan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DegreeplanExists(int id)
        {
            return _context.DegreePlans.Any(e => e.DegreeplanId == id);
        }
    }
}
