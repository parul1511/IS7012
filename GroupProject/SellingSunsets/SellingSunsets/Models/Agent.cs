using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace SellingSunsets.Models
{
    public class Agent
    {
        // AGENT ID

        [DisplayName("Agent ID")] 
        public int AgentId { get; set; }

        // AGENT NAME

        [DisplayName("Agent Name")] 
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Please Enter a valid Name")] 
        public string AgentName { get; set; }

        // AGENT PHONE NUMBER

        [DisplayName("Agent Phone Number")] // Relevant Property Name
        [RegularExpression("^[/+]?[(]?[0-9]{3}[)]?[-/s/.]?[0-9]{3}[-/s/.]?[0-9]{4,6}$",
        ErrorMessage = "Incorrect Phone Number.")] //US Phone Number Format +(xxx)-xxx-xxxx
        public string AgentPhNo { get; set; } 

        // AGENT ADDRESS

        [DisplayName("Agent Address")]  // Relevant Property Name
        [StringLength(40, MinimumLength = 10, ErrorMessage = "Please Enter a valid Address")]
        public string AgentAddress { get; set; }

        // AGENT EMAIL ADDRESS

        [DisplayName("Agent Email Id")] 
        [StringLength(40, MinimumLength = 10, ErrorMessage = "Please Enter a valid Email Address")]
        public String AgentEmailId { get; set; }

        // AGENT DOB

        [DisplayName("Agent Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime AgentDateOfBirth { get; set; }

        // AGENT Is Registered

        [DisplayName("Is Agent Registered")] 
        public bool AgentRegistered { get; set; }

        // AGENT SSN


        [DisplayName("Agent SSN")]
        [RegularExpression("^[0-9]{3}-?[0-9]{3}-?[0-9]{4}$",
            ErrorMessage = "Invalid SSN")]
        public string AgentSSN { get; set; }

        //AGENT SALARY

        [DisplayName("Agent Salary")]
        [Range(50000, 1000000, ErrorMessage = "Please enter a valid Maximum Salary")]
        public long AgentSalary { get; set; }

        // Relationships

        [DisplayName("Sales Office Name")]
        public SalesOffice SalesOffice { get; set; }

        [DisplayName("Sales Office Name")]
        public int SalesOfficeId { get; set; }
        public List<Dwelling> Dwellings { get; set; }

    }
}
