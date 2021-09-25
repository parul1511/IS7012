using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatRanjanpl.Models
{
    public class JobTitle
    {
        [Range(0, 100000000000)]
        [DisplayName("Job Title ID")]
        public int JobTitleId { get; set; }

        [Required(ErrorMessage = "Jib Title is  required")]
        [StringLength(100)]
        [DisplayName("Job Title")]
        public string Title { get; set; }

        [Range(0, 100000000)]
        [DisplayName("Minimum Salary")]
        public decimal MinSalary { get; set; }

        [Range(0, 100000000)]
        [DisplayName("Maximum Salary")]
        public decimal MaxSalary { get; set; }

        public List<Candidate> Candidates { get; set; }
        [DisplayName("Candidate ID")]
        [Range(0, 100000000)]
        public int CandidateId { get; set; }
    }
}
