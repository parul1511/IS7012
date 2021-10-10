using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SellingSunsets.Data;
using SellingSunsets.Models;

namespace SellingSunsets.Pages.Agents
{
    public class DetailsModel : PageModel
    {
        private readonly SellingSunsets.Data.SellingSunsetsContext _context;

        public DetailsModel(SellingSunsets.Data.SellingSunsetsContext context)
        {
            _context = context;
        }

        public Agent Agent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {


            if (id == null)
            {
                return NotFound();
            }

            
            Agent = await _context.Agent
                .Include(x => x.Dwellings)
                .Include(x => x.SalesOffice)
                .FirstOrDefaultAsync(m => m.AgentId == id);

            if (Agent == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
