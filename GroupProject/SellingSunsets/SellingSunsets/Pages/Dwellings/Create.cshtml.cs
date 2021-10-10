using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SellingSunsets.Data;
using SellingSunsets.Models;

namespace SellingSunsets.Pages.Dwellings
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
        ViewData["AgentId"] = new SelectList(_context.Agent, "AgentId", "AgentName");
        ViewData["CityId"] = new SelectList(_context.City, "CityId", "CityName");
            return Page();
        }

        [BindProperty]
        public Dwelling Dwelling { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dwelling.Add(Dwelling);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
