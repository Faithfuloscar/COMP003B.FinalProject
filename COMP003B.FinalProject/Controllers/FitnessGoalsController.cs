using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COMP003B.FinalProject.Data;
using COMP003B.FinalProject.Models;

namespace COMP003B.FinalProject.Controllers
{
    public class FitnessGoalsController : Controller
    {
        private readonly FitContext _context;

        public FitnessGoalsController(FitContext context)
        {
            _context = context;
        }

        // GET: FitnessGoals
        public async Task<IActionResult> Index()
        {
            return View(await _context.FitnessGoal.ToListAsync());
        }

        // GET: FitnessGoals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitnessGoal = await _context.FitnessGoal
                .FirstOrDefaultAsync(m => m.FitnessGoalId == id);
            if (fitnessGoal == null)
            {
                return NotFound();
            }

            return View(fitnessGoal);
        }

        // GET: FitnessGoals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FitnessGoals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FitnessGoalId,UserId,GoalType,TargetDate")] FitnessGoal fitnessGoal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fitnessGoal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fitnessGoal);
        }

        // GET: FitnessGoals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitnessGoal = await _context.FitnessGoal.FindAsync(id);
            if (fitnessGoal == null)
            {
                return NotFound();
            }
            return View(fitnessGoal);
        }

        // POST: FitnessGoals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FitnessGoalId,UserId,GoalType,TargetDate")] FitnessGoal fitnessGoal)
        {
            if (id != fitnessGoal.FitnessGoalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fitnessGoal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FitnessGoalExists(fitnessGoal.FitnessGoalId))
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
            return View(fitnessGoal);
        }

        // GET: FitnessGoals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitnessGoal = await _context.FitnessGoal
                .FirstOrDefaultAsync(m => m.FitnessGoalId == id);
            if (fitnessGoal == null)
            {
                return NotFound();
            }

            return View(fitnessGoal);
        }

        // POST: FitnessGoals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fitnessGoal = await _context.FitnessGoal.FindAsync(id);
            if (fitnessGoal != null)
            {
                _context.FitnessGoal.Remove(fitnessGoal);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FitnessGoalExists(int id)
        {
            return _context.FitnessGoal.Any(e => e.FitnessGoalId == id);
        }
    }
}
