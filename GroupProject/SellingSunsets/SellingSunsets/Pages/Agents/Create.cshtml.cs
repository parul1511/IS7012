using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SellingSunsets.Data;
using SellingSunsets.Models;
using Microsoft.EntityFrameworkCore;


namespace SellingSunsets.Pages.Agents
{
    public class CreateModel : PageModel
    {
        private readonly SellingSunsets.Data.SellingSunsetsContext _context;

        public CreateModel(SellingSunsets.Data.SellingSunsetsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SalesOfficeId"] = new SelectList(_context.Set<SalesOffice>(), "SalesOfficeId", "SalesOfficeName");
            return Page();
        }

        [BindProperty]
        public Agent Agent { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // FORM VALIDATION RULES
            // DATE OF BIRTH VALIDATION RULES
            var birthYear = Agent.AgentDateOfBirth.Year;
            var latestAllowedYear = DateTime.Now.Year - 18;
            if(birthYear > latestAllowedYear)
            {
                ModelState.AddModelError("Agent.AgentDateOfBirth", "Agent must be 18 years or older");
            }

            // SSN VALIDATION
            var ssn = Agent.AgentSSN;
            
            bool ssnAlreadyExists = await _context.Agent.AnyAsync(x => x.AgentSSN == ssn);

            if (ssnAlreadyExists)
            {
                ModelState.AddModelError("Agent.AgentSSN", "Account holder with this SSN Already exists");
            }

            ViewData["SalesOfficeId"] = new SelectList(_context.Set<SalesOffice>(), "SalesOfficeId", "SalesOfficeName");
            

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Agent.Add(Agent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");


        }
    }
}
