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
    public class StudentTermsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentTermsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StudentTerms
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["DegreeSortParm"] =  String.IsNullOrEmpty(sortOrder) ? "degree_desc" : "";
            ViewData["TermsSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Terms_desc" : ""; 
            ViewData["TermSortParm"] = sortOrder == "Term" ? "term_desc" : "Term";
            ViewData["CurrentFilter"] = searchString;
            var studentTerms = from s in _context.StudentTerms
                               select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                studentTerms = studentTerms.Where(s => s.Term.ToString().Contains(searchString)
                                 || s.TermAbv.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "degree_desc":
                    studentTerms = studentTerms.OrderByDescending(s => s.DegreeplanId);
                    break;
                case "Terms_desc":
                    studentTerms = studentTerms.OrderByDescending(s => s.TermAbv);
                    break;
                case "Term":
                    studentTerms = studentTerms.OrderBy(s => s.Term);
                    break;

                case "term_desc":
                    studentTerms = studentTerms.OrderByDescending(s => s.Term);
                    break;
                default:
                    studentTerms = studentTerms.OrderBy(s => s.StudentTermId);
                    break;
            }
            //var applicationDbContext = _context.StudentTerms.Include(s => s.StudentTermId).Include(s => s.DegreePlan);
            //return View(await applicationDbContext.ToListAsync());
            return View(await studentTerms.AsNoTracking().ToListAsync());
        }

        // GET: StudentTerms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentTerm = await _context.StudentTerms
                .Include(s => s.DegreePlan)
                .FirstOrDefaultAsync(m => m.StudentTermId == id);
            if (studentTerm == null)
            {
                return NotFound();
            }

            return View(studentTerm);
        }

        // GET: StudentTerms/Create
        public IActionResult Create()
        {
            ViewData["DegreeplanId"] = new SelectList(_context.DegreePlans, "DegreeplanId", "DegreeplanId");
            return View();
        }

        // POST: StudentTerms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentTermId,Term,TermAbv,TermName,DegreeplanId")] StudentTerm studentTerm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentTerm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DegreeplanId"] = new SelectList(_context.DegreePlans, "DegreeplanId", "DegreeplanId", studentTerm.DegreeplanId);
            return View(studentTerm);
        }

        // GET: StudentTerms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentTerm = await _context.StudentTerms.FindAsync(id);
            if (studentTerm == null)
            {
                return NotFound();
            }
            ViewData["DegreeplanId"] = new SelectList(_context.DegreePlans, "DegreeplanId", "DegreeplanId", studentTerm.DegreeplanId);
            return View(studentTerm);
        }

        // POST: StudentTerms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentTermId,Term,TermAbv,TermName,DegreeplanId")] StudentTerm studentTerm)
        {
            if (id != studentTerm.StudentTermId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentTerm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentTermExists(studentTerm.StudentTermId))
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
            ViewData["DegreeplanId"] = new SelectList(_context.DegreePlans, "DegreeplanId", "DegreeplanId", studentTerm.DegreeplanId);
            return View(studentTerm);
        }

        // GET: StudentTerms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentTerm = await _context.StudentTerms
                .Include(s => s.DegreePlan)
                .FirstOrDefaultAsync(m => m.StudentTermId == id);
            if (studentTerm == null)
            {
                return NotFound();
            }

            return View(studentTerm);
        }

        // POST: StudentTerms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentTerm = await _context.StudentTerms.FindAsync(id);
            _context.StudentTerms.Remove(studentTerm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentTermExists(int id)
        {
            return _context.StudentTerms.Any(e => e.StudentTermId == id);
        }
    }
}
