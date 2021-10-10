using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SellingSunsets.Models
{
    public class Dwelling
    {
        // Dwelling ID
        [DisplayName("Dwelling ID")] // Relevant Property Name
        public int DwellingId { get; set; }

        // Dwelling Name

        [DisplayName("Dwelling Name")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Please Enter a valid Name")]
        public string DwellingName { get; set; }

        // Dwelling Address

        [DisplayName("Dwelling Address")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "Please Enter a valid Address")]
        public string DwellingAddress { get; set; }

        // No of Occupants

        [DisplayName("No of Occupants")]
        [Range(1, 5, ErrorMessage = "Please enter a valid No of Occupants")]
        public int DwellingNoOfOccupant { get; set; }

        // Area in Sq Ft

        [DisplayName("Dwelling Area in Sq Ft")] 
        public string DwellingArea { get; set; }

        // Home Description & Paragraph

        [DisplayName("Dwelling Room Description")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Please Enter a valid Room Description")]
        public String DwellingRoom { get; set; }

        // Dwelling Registration Number

        [DisplayName("Dwelling Registration Number")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Please Enter a valid Reg Number")]
        public String DwellingRegNo { get; set; }

        // Registration Date

        [DisplayName("Dwelling Registration Date")]
        [DataType(DataType.Date)]
        public DateTime DwellingDateOfReg { get; set; }

        // Relationships
       
        public Agent Agent { get; set; }
        [DisplayName("Agent Name")]
        public int AgentId { get; set; }
        public City City { get; set; }
        [DisplayName("City Name")]
        public int CityId { get; set; }

    }
}
