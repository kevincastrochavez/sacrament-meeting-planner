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
    public class SpeakerController : Controller
    {
        private readonly sacramentMeetingPlannerContext _context;

        public SpeakerController(sacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        // GET: Speaker
        public async Task<IActionResult> Index()
        {
            var speakerContext = _context.Speaker.Include(s => s.SacramentMeeting);
            return View(await speakerContext.ToListAsync());
        }

        // GET: Speaker/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Speaker == null)
            {
                return NotFound();
            }

            var speaker = await _context.Speaker
                .Include(s => s.SacramentMeeting)
                .FirstOrDefaultAsync(m => m.SpeakerID == id);
            if (speaker == null)
            {
                return NotFound();
            }

            return View(speaker);
        }

        // GET: Speaker/Create
        public IActionResult Create(int? id)
        {
            // Console.WriteLine(id);
            ViewData["SacramentMeetingID"] = id;
            return View();
        }

        // POST: Speaker/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpeakerID,Name,SubjectType,Gender,SacramentMeetingID")] Speaker speaker, int? id)
        {
            if (ModelState.IsValid)
            {
                _context.Add(speaker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }

            ViewData["SacramentMeetingID"] = id;

            return View(speaker);
        }

        // GET: Speaker/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Speaker == null)
            {
                return NotFound();
            }

            var speaker = await _context.Speaker.FindAsync(id);
            if (speaker == null)
            {
                return NotFound();
            }
            return View(speaker);
        }

        // POST: Speaker/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpeakerID,Name,SubjectType,Gender,SacramentMeetingID")] Speaker speaker)
        {
            if (id != speaker.SpeakerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(speaker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpeakerExists(speaker.SpeakerID))
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
            return View(speaker);
        }

        // GET: Speaker/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Speaker == null)
            {
                return NotFound();
            }

            var speaker = await _context.Speaker
                .FirstOrDefaultAsync(m => m.SpeakerID == id);
            if (speaker == null)
            {
                return NotFound();
            }

            return View(speaker);
        }

        // POST: Speaker/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Speaker == null)
            {
                return Problem("Entity set 'sacramentMeetingPlannerContext.Speaker'  is null.");
            }
            var speaker = await _context.Speaker.FindAsync(id);
            if (speaker != null)
            {
                _context.Speaker.Remove(speaker);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpeakerExists(int id)
        {
          return (_context.Speaker?.Any(e => e.SpeakerID == id)).GetValueOrDefault();
        }
    }
}
