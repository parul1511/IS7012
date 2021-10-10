using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SellingSunsets.Data;
using SellingSunsets.Models;

namespace SellingSunsets.Pages.Dwellings
{
    public class IndexModel : PageModel
    {
        private readonly SellingSunsets.Data.SellingSunsetsContext _context;

        public IndexModel(SellingSunsets.Data.SellingSunsetsContext context)
        {
            _context = context;
        }

        public IList<Dwelling> Dwelling { get;set; }

        public async Task OnGetAsync()
        {
            Dwelling = await _context.Dwelling
                .Include(d => d.Agent)
                .Include(d => d.City).ToListAsync();
        }
    }
}
