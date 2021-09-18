using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatRanjanpl.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string CandidateFirstName { get; set; }
        public string CandidateLastName { get; set; }
        public decimal TargetSalary { get; set; }
        public DateTime? OptionalStartDate { get; set; }
        public DateTime CandidateDOB { get; set; }
        public string CandidatePhoneNo { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
    }
}
