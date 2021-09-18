using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatRanjanpl.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string PositionName { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public string Location { get; set; }
        public bool isFortune400Company { get; set; }
        public int NoOfEmployees { get; set; }
        public List<Candidate> Candidate { get; set; }
        public int CandidateId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
    }
}
