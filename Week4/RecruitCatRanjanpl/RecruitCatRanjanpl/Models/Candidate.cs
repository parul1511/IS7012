using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatRanjanpl.Models
{
    public class Candidate
    {
        [DisplayName("Candidate ID")]
        public int CandidateId { get; set; }
        
        [Required(ErrorMessage ="First Name is  required")]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string CandidateFirstName { get; set; }
        
        [Required(ErrorMessage = "Last Name is  required")]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string CandidateLastName { get; set; }
        
        [DisplayName("Name")]
        public string FullName
        {
            get
            {
                return $"{CandidateFirstName} {CandidateLastName}";
            }
        }
        
        [DisplayName("Target Salary")]
        [Range(0,100000000)]
        public decimal TargetSalary { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayName("Optional Start Date")]
        public DateTime? OptionalStartDate { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        public DateTime CandidateDOB { get; set; }
        
        [Required(ErrorMessage = "Phone No is  required")]
        [RegularExpression("^[/+]?[(]?[0-9]{3}[)]?[-/s/.]?[0-9]{3}[-/s/.]?[0-9]{4,6}$")]
        [DisplayName("Phone No.")]
        public string CandidatePhoneNo { get; set; }
        
        public Company Company { get; set; }
        [DisplayName("Company ID")]
        [Range(0, 100000000)]
        public int? CompanyId { get; set; }
        
        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        [DisplayName("Job Title ID")]
        [Range(0, 100000000)]
        public int JobTitleId { get; set; }
        
        public Industry Industry { get; set; }
        [DisplayName("Industry ID")]
        [Range(0, 100000000)]
        public int IndustryId { get; set; }
    }
}
