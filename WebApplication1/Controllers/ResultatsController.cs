using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DS_GabertEtienne.Models;
using WebApplication1.Data;

namespace DS_GabertEtienne.Controllers
{
    public class ResultatsController : Controller
    {
        private readonly WebApplication1Context _context;

        public ResultatsController(WebApplication1Context context)
        {
            _context = context;
        }

        // GET: Resultats
        public async Task<IActionResult> Index()
        {
            return View(await _context.Resultat.ToListAsync());
        }

        // GET: Resultats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resultat = await _context.Resulat
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resultat == null)
            {
                return NotFound();
            }

            return View(resultat);
        }

        // GET: Resultats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Resultats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Score1,Score2,DateDebut")] Resultat resultat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resultat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resultat);
        }

        // GET: Resultats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resultat = await _context.Resulat.FindAsync(id);
            if (resultat == null)
            {
                return NotFound();
            }
            return View(resultat);
        }

        // POST: Resultats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Score1,Score2,DateDebut")] Resultat resultat)
        {
            if (id != resultat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resultat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResultatExists(resultat.Id))
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
            return View(resultat);
        }

        // GET: Resultats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resultat = await _context.Resulat
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resultat == null)
            {
                return NotFound();
            }

            return View(resultat);
        }

        // POST: Resultats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resultat = await _context.Resulat.FindAsync(id);
            _context.Resulat.Remove(resultat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResultatExists(int id)
        {
            return _context.Resulat.Any(e => e.Id == id);
        }
    }
}
