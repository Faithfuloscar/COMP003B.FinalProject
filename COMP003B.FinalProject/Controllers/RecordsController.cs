﻿using System;
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
    public class RecordsController : Controller
    {
        private readonly FitContext _context;

        public RecordsController(FitContext context)
        {
            _context = context;
        }

        // GET: Records
        public async Task<IActionResult> Index()
        {
            var fitContext = _context.Record.Include(@ => @.Exercise).Include(@ => @.FitnessGoal).Include(@ => @.Location).Include(@ => @.Session).Include(@ => @.Users);
            return View(await fitContext.ToListAsync());
        }

        // GET: Records/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @record = await _context.Record
                .Include(@ => @.Exercise)
                .Include(@ => @.FitnessGoal)
                .Include(@ => @.Location)
                .Include(@ => @.Session)
                .Include(@ => @.Users)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@record == null)
            {
                return NotFound();
            }

            return View(@record);
        }

        // GET: Records/Create
        public IActionResult Create()
        {
            ViewData["ExerciseId"] = new SelectList(_context.Exercises, "ExerciseId", "ExerciseId");
            ViewData["FitnessGoalId"] = new SelectList(_context.FitnessGoal, "FitnessGoalId", "FitnessGoalId");
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationId");
            ViewData["SessionId"] = new SelectList(_context.Session, "SessionId", "SessionId");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserName");
            return View();
        }

        // POST: Records/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,SessionId,FitnessGoalId,TypeId,ExerciseId,LocationId")] Record @record)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@record);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ExerciseId"] = new SelectList(_context.Exercises, "ExerciseId", "ExerciseId", @record.ExerciseId);
            ViewData["FitnessGoalId"] = new SelectList(_context.FitnessGoal, "FitnessGoalId", "FitnessGoalId", @record.FitnessGoalId);
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationId", @record.LocationId);
            ViewData["SessionId"] = new SelectList(_context.Session, "SessionId", "SessionId", @record.SessionId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserName", @record.UserId);
            return View(@record);
        }

        // GET: Records/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @record = await _context.Record.FindAsync(id);
            if (@record == null)
            {
                return NotFound();
            }
            ViewData["ExerciseId"] = new SelectList(_context.Exercises, "ExerciseId", "ExerciseId", @record.ExerciseId);
            ViewData["FitnessGoalId"] = new SelectList(_context.FitnessGoal, "FitnessGoalId", "FitnessGoalId", @record.FitnessGoalId);
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationId", @record.LocationId);
            ViewData["SessionId"] = new SelectList(_context.Session, "SessionId", "SessionId", @record.SessionId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserName", @record.UserId);
            return View(@record);
        }

        // POST: Records/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,SessionId,FitnessGoalId,TypeId,ExerciseId,LocationId")] Record @record)
        {
            if (id != @record.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@record);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecordExists(@record.Id))
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
            ViewData["ExerciseId"] = new SelectList(_context.Exercises, "ExerciseId", "ExerciseId", @record.ExerciseId);
            ViewData["FitnessGoalId"] = new SelectList(_context.FitnessGoal, "FitnessGoalId", "FitnessGoalId", @record.FitnessGoalId);
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "LocationId", @record.LocationId);
            ViewData["SessionId"] = new SelectList(_context.Session, "SessionId", "SessionId", @record.SessionId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserName", @record.UserId);
            return View(@record);
        }

        // GET: Records/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @record = await _context.Record
                .Include(@ => @.Exercise)
                .Include(@ => @.FitnessGoal)
                .Include(@ => @.Location)
                .Include(@ => @.Session)
                .Include(@ => @.Users)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@record == null)
            {
                return NotFound();
            }

            return View(@record);
        }

        // POST: Records/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @record = await _context.Record.FindAsync(id);
            if (@record != null)
            {
                _context.Record.Remove(@record);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecordExists(int id)
        {
            return _context.Record.Any(e => e.Id == id);
        }
    }
}