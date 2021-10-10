using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SellingSunsets.Data;
using SellingSunsets.Models;

namespace SellingSunsets.Pages.Cities
{
    public class DetailsModel : PageModel
    {
        private readonly SellingSunsets.Data.SellingSunsetsContext _context;

        public DetailsModel(SellingSunsets.Data.SellingSunsetsContext context)
        {
            _context = context;
        }

        public City City { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            City = await _context.City
                .Include(x => x.Dwellings)
                .FirstOrDefaultAsync(m => m.CityId == id);


            if (City == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
