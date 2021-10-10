using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SellingSunsets.Data;
using SellingSunsets.Models;

namespace SellingSunsets.Pages.SalesOffices
{
    public class DetailsModel : PageModel
    {
        private readonly SellingSunsets.Data.SellingSunsetsContext _context;

        public DetailsModel(SellingSunsets.Data.SellingSunsetsContext context)
        {
            _context = context;
        }

        public SalesOffice SalesOffice { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SalesOffice = await _context.SalesOffice
                            .Include(x => x.Agents)
                            .FirstOrDefaultAsync(m => m.SalesOfficeId == id);

            if (SalesOffice == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
