using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatRanjanpl.Models;

namespace RecruitCatRanjanpl.Data
{
    public class RecruitCatRanjanplContext : DbContext
    {
        public RecruitCatRanjanplContext (DbContextOptions<RecruitCatRanjanplContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatRanjanpl.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatRanjanpl.Models.Company> Company { get; set; }

        public DbSet<RecruitCatRanjanpl.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatRanjanpl.Models.JobTitle> JobTitle { get; set; }
    }
}
