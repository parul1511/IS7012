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
    public class IndexModel : PageModel
    {
        private readonly SellingSunsets.Data.SellingSunsetsContext _context;

        public IndexModel(SellingSunsets.Data.SellingSunsetsContext context)
        {
            _context = context;
        }

        public IList<City> City { get;set; }

        public async Task OnGetAsync()
        {
            City = await _context.City.ToListAsync();
        }
    }
}
