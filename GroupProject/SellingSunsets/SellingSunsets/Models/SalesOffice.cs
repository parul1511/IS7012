using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SellingSunsets.Models
{
    public class SalesOffice
    { 
        // Sales Office ID
        [DisplayName("Sales Office ID")] 
        public int SalesOfficeId { get; set; }


        // Sales Office Name
        [DisplayName("Sales Office Name")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Please Enter a Valid Office Name")]
        public string SalesOfficeName { get; set; }
       

        [DisplayName("Sales Office Location")]
        [StringLength(36, MinimumLength = 3, ErrorMessage = "Please Enter a Valid Location")]
        public string SalesOfficeLoc { get; set; }

        // Sales office Phone NO

        [DisplayName("Sales Office Phone Number")]
        [RegularExpression("^[/+]?[(]?[0-9]{3}[)]?[-/s/.]?[0-9]{3}[-/s/.]?[0-9]{4,6}$",
        ErrorMessage = "Invalid Phone Number.")]
        public string SalesOfficePhNo { get; set; }

        // Relationships
        public List<Agent> Agents { get; set; }

    }
}
