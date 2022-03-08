using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ReasController : Controller
    {
        private readonly CovidContext _context;

        public ReasController(CovidContext context)
        {
            _context = context;
        }

        // GET: Reas
        public async Task<IActionResult> Index()
        {
            var covidContext = _context.Rea.Include(r => r.hospital);
            return View(await covidContext.ToListAsync());
        }

        // GET: Reas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rea = await _context.Rea
                .Include(r => r.hospital)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (rea == null)
            {
                return NotFound();
            }

            return View(rea);
        }

        // GET: Reas/Create
        public IActionResult Create()
        {
            ViewData["HospitalId"] = new SelectList(_context.Hospital, "ID", "nameHospital");
            return View();
        }

        // POST: Reas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,rea,numberBed,HospitalId")] Rea reau)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reau);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HospitalId"] = new SelectList(_context.Hospital, "ID", "nameHospital", reau.HospitalId);
            return View(reau);
        }

        // GET: Reas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rea = await _context.Rea.FindAsync(id);
            if (rea == null)
            {
                return NotFound();
            }
            ViewData["HospitalId"] = new SelectList(_context.Hospital, "ID", "nameHospital", rea.HospitalId);
            return View(rea);
        }

        // POST: Reas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,rea,numberBed,HospitalId")] Rea reau)
        {
            if (id != reau.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reau);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReaExists(reau.ID))
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
            ViewData["HospitalId"] = new SelectList(_context.Hospital, "ID", "nameHospital", reau.HospitalId);
            return View(reau);
        }

        // GET: Reas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rea = await _context.Rea
                .Include(r => r.hospital)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (rea == null)
            {
                return NotFound();
            }

            return View(rea);
        }

        // POST: Reas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rea = await _context.Rea.FindAsync(id);
            _context.Rea.Remove(rea);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReaExists(int id)
        {
            return _context.Rea.Any(e => e.ID == id);
        }
    }
}
