using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatRanjanpl.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }
        public string Name { get; set; }
        public List<Candidate> Candidates { get; set; }
        public int CandidateId { get; set; }
        public decimal? IndustrySales { get; set; }
        public int NumberOfFirms { get; set; }
        public List<Company> Companies { get; set; }
        public int CompanyId { get; set; }
    }
}
