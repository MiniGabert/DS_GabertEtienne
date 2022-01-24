using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace DS_GabertEtienne.Controllers
{
    public class ChampionnatsController : Controller
    {
        private readonly WebApplication1Context _context;

        public ChampionnatsController(WebApplication1Context context)
        {
            _context = context;
        }

        // GET: Championnats
        public async Task<IActionResult> Index()
        {
            return View(await _context.Championnat.ToListAsync());
        }

        // GET: Championnats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var championnat = await _context.Championnat
                .FirstOrDefaultAsync(m => m.Id == id);
            if (championnat == null)
            {
                return NotFound();
            }

            return View(championnat);
        }

        // GET: Championnats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Championnats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom")] Championnat championnat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(championnat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(championnat);
        }

        // GET: Championnats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var championnat = await _context.Championnat.FindAsync(id);
            if (championnat == null)
            {
                return NotFound();
            }
            return View(championnat);
        }

        // POST: Championnats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom")] Championnat championnat)
        {
            if (id != championnat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(championnat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChampionnatExists(championnat.Id))
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
            return View(championnat);
        }

        // GET: Championnats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var championnat = await _context.Championnat
                .FirstOrDefaultAsync(m => m.Id == id);
            if (championnat == null)
            {
                return NotFound();
            }

            return View(championnat);
        }

        // POST: Championnats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var championnat = await _context.Championnat.FindAsync(id);
            _context.Championnat.Remove(championnat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChampionnatExists(int id)
        {
            return _context.Championnat.Any(e => e.Id == id);
        }
    }
}
