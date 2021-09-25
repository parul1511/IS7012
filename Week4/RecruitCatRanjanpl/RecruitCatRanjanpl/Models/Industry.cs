using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatRanjanpl.Models
{
    public class Industry
    {
        [Range(0, 100000000)]
        [DisplayName("Industry ID")]
        public int IndustryId { get; set; }

        [Required(ErrorMessage = "Industry Name is  required")]
        [StringLength(100)]
        [DisplayName("Industry Name")]
        public string Name { get; set; }

        public List<Candidate> Candidates { get; set; }
        [Range(0, 100000000)]
        [DisplayName("Candidate ID")]
        public int CandidateId { get; set; }

        [Range(0,10000000000000000)]
        [DisplayName("Industry Sales")]
        public decimal? IndustrySales { get; set; }

        [Range(0, 1000000000)]
        [DisplayName("No of Firms")]
        public int NumberOfFirms { get; set; }

        public List<Company> Companies { get; set; }
        [Range(0, 100000000)]
        [DisplayName("Company ID")]
        public int CompanyId { get; set; }
    }
}
