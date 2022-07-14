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
            var sacramentMeetingPlannerContext = _context.SacramentMeeting.Include(s => s.Bishopric).Include(s => s.Hymn).Include(s => s.OpeningHymn).Include(s => s.SacramentHymn).Include(s => s.ClosingHymn).Include(s => s.DismissalHymn).Include(s => s.Presiding).Include(s => s.Conducting).Include(s => s.MusicalNumber);
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
                .Include(s => s.OpeningHymn)
                .Include(s => s.SacramentHymn)
                .Include(s => s.ClosingHymn)
                .Include(s => s.DismissalHymn)
                .Include(s => s.Presiding)
                .Include(s => s.Conducting)
                .Include(s => s.MusicalNumber)
                .FirstOrDefaultAsync(m => m.SacramentMeetingID == id);
            if (sacramentMeeting == null)
            {
                return NotFound();
            }

            // var speaker = await _context.Speaker
            //     .Include(s => s.SacramentMeeting)
            //     .FirstOrDefaultAsync(m => m.SpeakerID == id);
            var speakers = from s in _context.Speaker
                            select s;

            speakers = speakers.Where(s => s.SacramentMeetingID == sacramentMeeting.SacramentMeetingID);
            var speakerCounter = 0;
            foreach (var person in speakers)
            {
                speakerCounter++;
            }
            ViewData["SacramentSpeakers"] = speakers;
            ViewData["SpeakerCounter"] = speakerCounter;

            // foreach (var person in speakers)
            // {
            //     Console.WriteLine(person.Name);
            // }
            // Console.WriteLine(speakers);
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
        public async Task<IActionResult> Create([Bind("Invocation,Benediction,Date,OpeningHymnID,SacramentHymnID,ClosingHymnID,DismissalHymnID,PresidingID,ConductingID,HymnID,BishopricID,MusicalNumberID,MusicalPerformance")] SacramentMeeting sacramentMeeting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sacramentMeeting);
                await _context.SaveChangesAsync();
                // Console.WriteLine(sacramentMeeting.SacramentMeetingID); It cannot be accessed (returns a 0)
                return RedirectToRoute(new {
                    controller = "Speaker",
                    action = "Create",
                });
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
        public async Task<IActionResult> Edit(int id, [Bind("SacramentMeetingID,Invocation,Benediction,Date,OpeningHymnID,SacramentHymnID,ClosingHymnID,DismissalHymnID,PresidingID,ConductingID,HymnID,BishopricID,MusicalNumberID,MusicalPerformance")] SacramentMeeting sacramentMeeting)
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

            var sacramentMeeting = await _context.SacramentMeeting.
                Include(s => s.Bishopric).Include(s => s.Hymn).Include(s => s.OpeningHymn).Include(s => s.SacramentHymn).Include(s => s.ClosingHymn).Include(s => s.DismissalHymn).Include(s => s.Presiding).Include(s => s.Conducting).Include(s => s.MusicalNumber)
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
            
            // return View(await sacramentMeetingPlannerContext.ToListAsync());;
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
