using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using olderTask.Models;

namespace olderTask.Controllers
{
    public class OLDERSController : Controller
    {
        private readonly DBCOUNT _context;

        public OLDERSController(DBCOUNT context)
        {
            _context = context;
        }

        // GET: OLDERS
        public async Task<IActionResult> Index()
        {
            return View(await _context.Olders.ToListAsync());
        }

        // GET: OLDERS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oLDERS = await _context.Olders
                .FirstOrDefaultAsync(m => m.id == id);
            if (oLDERS == null)
            {
                return NotFound();
            }

            return View(oLDERS);
        }

        // GET: OLDERS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OLDERS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,subject,price,date")] OLDERS oLDERS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oLDERS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oLDERS);
        }

        // GET: OLDERS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oLDERS = await _context.Olders.FindAsync(id);
            if (oLDERS == null)
            {
                return NotFound();
            }
            return View(oLDERS);
        }

        // POST: OLDERS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,subject,price,date")] OLDERS oLDERS)
        {
            if (id != oLDERS.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oLDERS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OLDERSExists(oLDERS.id))
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
            return View(oLDERS);
        }

        // GET: OLDERS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oLDERS = await _context.Olders
                .FirstOrDefaultAsync(m => m.id == id);
            if (oLDERS == null)
            {
                return NotFound();
            }

            return View(oLDERS);
        }

        // POST: OLDERS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oLDERS = await _context.Olders.FindAsync(id);
            _context.Olders.Remove(oLDERS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OLDERSExists(int id)
        {
            return _context.Olders.Any(e => e.id == id);
        }
    }
}
