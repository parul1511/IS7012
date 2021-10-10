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
    public class SearchModel : PageModel
    {
        private readonly SellingSunsets.Data.SellingSunsetsContext _context;

        public SearchModel(SellingSunsets.Data.SellingSunsetsContext context)
        {
            _context = context;
        }

        public IList<Dwelling> Dwelling { get;set; }
        public bool SearchCompleted { get; set; }
        public string Query { get; set; }

        public async Task OnGetAsync(string query, int? id)
        {

            Query = query;
            if (!string.IsNullOrWhiteSpace(query))
            {
                SearchCompleted = true;
                Dwelling = await _context.Dwelling
                            .Include(d => d.Agent)
                            .Include(d => d.City)
                            .Where(x => x.DwellingName.StartsWith(query, StringComparison.InvariantCultureIgnoreCase))
                            .ToListAsync();

            }
          
            else
            {
                SearchCompleted = false;
                Dwelling = new List<Dwelling>();
            }
            
        }

    }
}
