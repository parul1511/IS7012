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
    public class SearchModel : PageModel
    {
        private readonly SellingSunsets.Data.SellingSunsetsContext _context;

        public SearchModel(SellingSunsets.Data.SellingSunsetsContext context)
        {
            _context = context;
        }

        public IList<Agent> Agent { get;set; }
        public bool SearchCompleted { get; set; }
        public string Query { get; set; }


        public async Task OnGetAsync(string query)
        {
            Query = query;
            if (!string.IsNullOrWhiteSpace(query))
            {
                SearchCompleted = true;
                Agent = await _context.Agent
                            .Where(x => x.AgentName.Contains(query))
                            .ToListAsync();

            }
            else
            {
                SearchCompleted = false;
                Agent = new List<Agent>();
            }
        }
    }
}
