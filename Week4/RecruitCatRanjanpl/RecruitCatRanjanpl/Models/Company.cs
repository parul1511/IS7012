using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatRanjanpl.Models
{
    public class Company
    {
        [Range(0, 100000000)]
        [DisplayName("Company ID")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Company Name is  required")]
        [StringLength(100)]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Position Name is  required")]
        [StringLength(100)]
        [DisplayName("Position Name")]
        public string PositionName { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }

        [Range(0, 100000000)]
        [DisplayName("Minimum Salary")]
        public decimal MinSalary { get; set; }

        [Range(0, 100000000)]
        [DisplayName("Maximum Salary")]
        public decimal MaxSalary { get; set; }

        [Required(ErrorMessage = "Position Name is  required")]
        [StringLength(5000)]
        [DisplayName("Location")]
        public string Location { get; set; }

        [DisplayName("Is it a Fortune400 Company")]
        public bool isFortune400Company { get; set; }

        [Range(0,100000000000)]
        [DisplayName("No of Employee")]
        public int NoOfEmployees { get; set; }

        public List<Candidate> Candidate { get; set; }
        [Range(0, 100000000)]
        [DisplayName("Candidate ID")]
        public int CandidateId { get; set; }

        public Industry Industry { get; set; }
        [DisplayName("Industry ID")]
        [Range(0, 100000000)]
        public int IndustryId { get; set; }

        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        [DisplayName("Job Title ID")]
        [Range(0, 100000000)]
        public int JobTitleId { get; set; }
    }
}
