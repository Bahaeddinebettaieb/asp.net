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
    public class Consultation2Controller : Controller
    {
        private readonly CovidContext _context;

        public Consultation2Controller(CovidContext context)
        {
            _context = context;
        }

        // GET: Consultation2
        public async Task<IActionResult> Index()
        {
            var covidContext = _context.Consultation2.Include(c => c.doctor).Include(c => c.hospital);
            return View(await covidContext.ToListAsync());
        }

        // GET: Consultation2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultation2 = await _context.Consultation2
                .Include(c => c.doctor)
                .Include(c => c.hospital)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (consultation2 == null)
            {
                return NotFound();
            }

            return View(consultation2);
        }

        // GET: Consultation2/Create
        public IActionResult Create()
        {
            ViewData["DoctorId"] = new SelectList(_context.Medecin, "ID", "medecinName");
            ViewData["HospitalId"] = new SelectList(_context.Hospital, "ID", "nameHospital");
            return View();
        }

        // POST: Consultation2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,date,patient,HospitalId,DoctorId")] Consultation2 consultation2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consultation2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoctorId"] = new SelectList(_context.Medecin, "ID", "medecinName", consultation2.DoctorId);
            ViewData["HospitalId"] = new SelectList(_context.Hospital, "ID", "nameHospital", consultation2.HospitalId);
            return View(consultation2);
        }

        // GET: Consultation2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultation2 = await _context.Consultation2.FindAsync(id);
            if (consultation2 == null)
            {
                return NotFound();
            }
            ViewData["DoctorId"] = new SelectList(_context.Medecin, "ID", "medecinName", consultation2.DoctorId);
            ViewData["HospitalId"] = new SelectList(_context.Hospital, "ID", "nameHospital", consultation2.HospitalId);
            return View(consultation2);
        }

        // POST: Consultation2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,date,patient,HospitalId,DoctorId")] Consultation2 consultation2)
        {
            if (id != consultation2.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consultation2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Consultation2Exists(consultation2.ID))
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
            ViewData["DoctorId"] = new SelectList(_context.Medecin, "ID", "medecinName", consultation2.DoctorId);
            ViewData["HospitalId"] = new SelectList(_context.Hospital, "ID", "nameHospital", consultation2.HospitalId);
            return View(consultation2);
        }

        // GET: Consultation2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultation2 = await _context.Consultation2
                .Include(c => c.doctor)
                .Include(c => c.hospital)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (consultation2 == null)
            {
                return NotFound();
            }

            return View(consultation2);
        }

        // POST: Consultation2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consultation2 = await _context.Consultation2.FindAsync(id);
            _context.Consultation2.Remove(consultation2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Consultation2Exists(int id)
        {
            return _context.Consultation2.Any(e => e.ID == id);
        }
    }
}
