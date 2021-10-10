using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SellingSunsets.Data;
using SellingSunsets.Models;


namespace SellingSunsets.Pages.Agents
{
    public class EditModel : PageModel
    {
        private readonly SellingSunsets.Data.SellingSunsetsContext _context;

        public EditModel(SellingSunsets.Data.SellingSunsetsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Agent Agent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Agent = await _context.Agent
                .Include(a => a.SalesOffice).FirstOrDefaultAsync(m => m.AgentId == id);

            if (Agent == null)
            {
                return NotFound();
            }
           ViewData["SalesOfficeId"] = new SelectList(_context.Set<SalesOffice>(), "SalesOfficeId", "SalesOfficeName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // DATE OF BIRTH VALIDATION RULES
            var birthYear = Agent.AgentDateOfBirth.Year;
            var latestAllowedYear = DateTime.Now.Year - 18;
            if (birthYear > latestAllowedYear)
            {
                ModelState.AddModelError("Agent.AgentDateOfBirth", "Agent must be 18 years or older");
            }

            // SSN VALIDATION
            var ssn = Agent.AgentSSN;
            var currentId = Agent.AgentId;
            bool ssnAlreadyExists = await _context.Agent.AnyAsync(x => x.AgentSSN == ssn && x.AgentId != currentId);

            if (ssnAlreadyExists)
            {
                ModelState.AddModelError("Agent.AgentSSN", "Account holder with this SSN Already exists");
            }

            ViewData["SalesOfficeId"] = new SelectList(_context.Set<SalesOffice>(), "SalesOfficeId", "SalesOfficeName");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Agent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgentExists(Agent.AgentId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AgentExists(int id)
        {
            return _context.Agent.Any(e => e.AgentId == id);
        }
    }
}
