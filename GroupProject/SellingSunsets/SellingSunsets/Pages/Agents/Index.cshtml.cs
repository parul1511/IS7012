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
    public class IndexModel : PageModel
    {
        private readonly SellingSunsets.Data.SellingSunsetsContext _context;

        public IndexModel(SellingSunsets.Data.SellingSunsetsContext context)
        {
            _context = context;
        }


        public IList<Agent> Agent { get;set; }

        public int TotalAgents { get; set; }
        public double AverageAgentSalary { get; set; }

        public async Task OnGetAsync()
        {
            TotalAgents = await _context.Agent.CountAsync();
            AverageAgentSalary = await _context.Agent.AverageAsync(x => x.AgentSalary);

            Agent = await _context.Agent
                .Include(a => a.SalesOffice).ToListAsync();
        }
    }
}
