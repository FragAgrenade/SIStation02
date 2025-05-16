using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistation.Data;
using sistation.Models;

namespace sistation.Controllers
{
    public class SummariesController : Controller
    {
        private readonly ApplicationDbContext _context;


        public SummariesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Summaries
        public async Task<IActionResult> Index()
        {
            var summaries = await _context.Summaries
                .Include(s => s.User)
                .ToListAsync();
            return View(summaries);
        }

        // GET: Summaries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Summaries/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Content")] Summary summary)
        {
            summary.UserId = 2; // ID fixo para o usuário padrão

            if (ModelState.IsValid)
            {
                _context.Add(summary);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(summary);
        }

        // GET: Summaries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Summaries == null)
            {
                return NotFound();
            }

            var summary = await _context.Summaries.FindAsync(id);
            if (summary == null)
            {
                return NotFound();
            }
            return View(summary);
        }

        // POST: Summaries/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,UserId")] Summary summary)
        {
            if (id != summary.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(summary);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SummaryExists(summary.Id))
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
            return View(summary);
        }

        // GET: Summaries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Summaries == null)
            {
                return NotFound();
            }

            var summary = await _context.Summaries
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (summary == null)
            {
                return NotFound();
            }

            return View(summary);
        }

        // POST: Summaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Summaries == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Summaries' is null.");
            }
            var summary = await _context.Summaries.FindAsync(id);
            if (summary != null)
            {
                _context.Summaries.Remove(summary);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SummaryExists(int id)
        {
            return _context.Summaries.Any(e => e.Id == id);
        }
    }
}
