using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UI.Wizzard.Models;

namespace UI.Wizzard.Controllers
{
    public class FociController : Controller
    {
        private readonly SocialGoalContext _context;

        public FociController(SocialGoalContext context)
        {
            _context = context;
        }

        // GET: Foci
        public async Task<IActionResult> Index()
        {
            var socialGoalContext = _context.Foci.Include(f => f.Group);
            return View(await socialGoalContext.ToListAsync());
        }

        // GET: Foci/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foci = await _context.Foci
                .Include(f => f.Group)
                .FirstOrDefaultAsync(m => m.FocusId == id);
            if (foci == null)
            {
                return NotFound();
            }

            return View(foci);
        }

        // GET: Foci/Create
        public IActionResult Create()
        {
            ViewData["GroupId"] = new SelectList(_context.Groups, "GroupId", "GroupId");
            return View();
        }

        // POST: Foci/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FocusId,FocusName,Description,GroupId,CreatedDate")] Foci foci)
        {
            if (ModelState.IsValid)
            {
                _context.Add(foci);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupId"] = new SelectList(_context.Groups, "GroupId", "GroupId", foci.GroupId);
            return View(foci);
        }

        // GET: Foci/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foci = await _context.Foci.FindAsync(id);
            if (foci == null)
            {
                return NotFound();
            }
            ViewData["GroupId"] = new SelectList(_context.Groups, "GroupId", "GroupId", foci.GroupId);
            return View(foci);
        }

        // POST: Foci/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FocusId,FocusName,Description,GroupId,CreatedDate")] Foci foci)
        {
            if (id != foci.FocusId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(foci);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FociExists(foci.FocusId))
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
            ViewData["GroupId"] = new SelectList(_context.Groups, "GroupId", "GroupId", foci.GroupId);
            return View(foci);
        }

        // GET: Foci/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foci = await _context.Foci
                .Include(f => f.Group)
                .FirstOrDefaultAsync(m => m.FocusId == id);
            if (foci == null)
            {
                return NotFound();
            }

            return View(foci);
        }

        // POST: Foci/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var foci = await _context.Foci.FindAsync(id);
            _context.Foci.Remove(foci);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FociExists(int id)
        {
            return _context.Foci.Any(e => e.FocusId == id);
        }
    }
}
