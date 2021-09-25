using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatRanjanpl.Data;
using RecruitCatRanjanpl.Models;

namespace RecruitCatRanjanpl.Pages.Industries
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatRanjanpl.Data.RecruitCatRanjanplContext _context;

        public IndexModel(RecruitCatRanjanpl.Data.RecruitCatRanjanplContext context)
        {
            _context = context;
        }

        public IList<Industry> Industry { get;set; }

        public async Task OnGetAsync()
        {
            Industry = await _context.Industry.ToListAsync();
        }
    }
}
