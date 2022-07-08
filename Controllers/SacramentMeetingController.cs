using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sacramentMeetingPlanner.Models;
using sacramentMeetingPlanner.Data;

namespace sacramentMeetingPlanner.Controllers
{
    public class SacramentMeetingController : Controller
    {
        private readonly sacramentMeetingPlannerContext _context;

        public SacramentMeetingController(sacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        // GET: SacramentMeeting
        public async Task<IActionResult> Index()
        {
            var sacramentMeetingPlannerContext = _context.SacramentMeeting.Include(s => s.Bishopric).Include(s => s.Hymn);
            Console.Write(sacramentMeetingPlannerContext);
            return View(await sacramentMeetingPlannerContext.ToListAsync());
        }

        // GET: SacramentMeeting/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SacramentMeeting == null)
            {
                return NotFound();
            }

            var sacramentMeeting = await _context.SacramentMeeting
                .Include(s => s.Bishopric)
                .Include(s => s.Hymn)
                .FirstOrDefaultAsync(m => m.SacramentMeetingID == id);
            if (sacramentMeeting == null)
            {
                return NotFound();
            }

            return View(sacramentMeeting);
        }

        // GET: SacramentMeeting/Create
        public IActionResult Create()
        {
            ViewData["BishopricID"] = new SelectList(_context.Set<Bishopric>(), "BishopricID", "Calling");
            ViewData["HymnID"] = new SelectList(_context.Set<Hymn>(), "HymnID", "Title");
            return View();
        }

        // POST: SacramentMeeting/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SacramentMeetingID,Invocation,Benediction,Date,OpeningHymn,SacramentHymn,ClosingHymn,DismissalHymn,Presiding,Conducting,SpeakerID,BishopricID,HymnID")] SacramentMeeting sacramentMeeting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sacramentMeeting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BishopricID"] = new SelectList(_context.Set<Bishopric>(), "BishopricID", "Calling", sacramentMeeting.BishopricID);
            ViewData["HymnID"] = new SelectList(_context.Set<Hymn>(), "HymnID", "Title", sacramentMeeting.HymnID);
            return View(sacramentMeeting);
        }

        // GET: SacramentMeeting/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SacramentMeeting == null)
            {
                return NotFound();
            }

            var sacramentMeeting = await _context.SacramentMeeting.FindAsync(id);
            if (sacramentMeeting == null)
            {
                return NotFound();
            }
            ViewData["BishopricID"] = new SelectList(_context.Set<Bishopric>(), "BishopricID", "Calling", sacramentMeeting.BishopricID);
            ViewData["HymnID"] = new SelectList(_context.Set<Hymn>(), "HymnID", "Title", sacramentMeeting.HymnID);
            return View(sacramentMeeting);
        }

        // POST: SacramentMeeting/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SacramentMeetingID,Invocation,Benediction,Date,OpeningHymn,SacramentHymn,ClosingHymn,DismissalHymn,Presiding,Conducting,SpeakerID,BishopricID,HymnID")] SacramentMeeting sacramentMeeting)
        {
            if (id != sacramentMeeting.SacramentMeetingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sacramentMeeting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SacramentMeetingExists(sacramentMeeting.SacramentMeetingID))
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
            ViewData["BishopricID"] = new SelectList(_context.Set<Bishopric>(), "BishopricID", "Calling", sacramentMeeting.BishopricID);
            ViewData["HymnID"] = new SelectList(_context.Set<Hymn>(), "HymnID", "Title", sacramentMeeting.HymnID);
            return View(sacramentMeeting);
        }

        // GET: SacramentMeeting/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SacramentMeeting == null)
            {
                return NotFound();
            }

            var sacramentMeeting = await _context.SacramentMeeting
                .Include(s => s.Bishopric)
                .Include(s => s.Hymn)
                .FirstOrDefaultAsync(m => m.SacramentMeetingID == id);
            if (sacramentMeeting == null)
            {
                return NotFound();
            }

            return View(sacramentMeeting);
        }

        // POST: SacramentMeeting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SacramentMeeting == null)
            {
                return Problem("Entity set 'sacramentMeetingPlannerContext.SacramentMeeting'  is null.");
            }
            var sacramentMeeting = await _context.SacramentMeeting.FindAsync(id);
            if (sacramentMeeting != null)
            {
                _context.SacramentMeeting.Remove(sacramentMeeting);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SacramentMeetingExists(int id)
        {
          return (_context.SacramentMeeting?.Any(e => e.SacramentMeetingID == id)).GetValueOrDefault();
        }
    }
}
