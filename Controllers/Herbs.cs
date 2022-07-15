using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HerbalApothecary.Models;

namespace HerbalApothecary.Controllers
{
    public class Herbs : Controller
    {
        private readonly HerbContext _context;

        public Herbs(HerbContext context)
        {
            _context = context;
        }

        // GET: Herbs
        public async Task<IActionResult> Index()
        {
              return _context.Herbs != null ? 
                          View(await _context.Herbs.ToListAsync()) :
                          Problem("Entity set 'HerbContext.Herbs'  is null.");
        }

        // GET: Herbs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Herbs == null)
            {
                return NotFound();
            }

            var herb = await _context.Herbs
                .FirstOrDefaultAsync(m => m.HerbId == id);
            if (herb == null)
            {
                return NotFound();
            }

            return View(herb);
        }

        // GET: Herbs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Herbs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HerbId,CommonName,Uses,Contraindications,SideEffects,Tincture,Powder,Actions,Decoction,Energy,Notes,Safety,HerbExtraId")] Herb herb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(herb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(herb);
        }

        // GET: Herbs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Herbs == null)
            {
                return NotFound();
            }

            var herb = await _context.Herbs.FindAsync(id);
            if (herb == null)
            {
                return NotFound();
            }
            return View(herb);
        }

        // POST: Herbs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HerbId,CommonName,Uses,Contraindications,SideEffects,Tincture,Powder,Actions,Decoction,Energy,Notes,Safety,HerbExtraId")] Herb herb)
        {
            if (id != herb.HerbId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(herb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HerbExists(herb.HerbId))
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
            return View(herb);
        }

        // GET: Herbs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Herbs == null)
            {
                return NotFound();
            }

            var herb = await _context.Herbs
                .FirstOrDefaultAsync(m => m.HerbId == id);
            if (herb == null)
            {
                return NotFound();
            }

            return View(herb);
        }

        // POST: Herbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Herbs == null)
            {
                return Problem("Entity set 'HerbContext.Herbs'  is null.");
            }
            var herb = await _context.Herbs.FindAsync(id);
            if (herb != null)
            {
                _context.Herbs.Remove(herb);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HerbExists(int id)
        {
          return (_context.Herbs?.Any(e => e.HerbId == id)).GetValueOrDefault();
        }
    }
}
