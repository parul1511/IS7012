using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatRanjanpl.Data;
using RecruitCatRanjanpl.Models;

namespace RecruitCatRanjanpl.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatRanjanpl.Data.RecruitCatRanjanplContext _context;

        public DetailsModel(RecruitCatRanjanpl.Data.RecruitCatRanjanplContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company
                .Include(x => x.Candidate)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).FirstOrDefaultAsync(m => m.CompanyId == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
