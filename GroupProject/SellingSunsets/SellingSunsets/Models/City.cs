using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace SellingSunsets.Models
{
    public class City
    {
        // CITY ID
        [DisplayName("City ID")] // Relevant Property Name
        public int CityId { get; set; }

        // CITY NAME

        [DisplayName("City Name")]
        [StringLength(36, MinimumLength = 3, ErrorMessage = "Please Enter a Area")]
        public string CityName { get; set; }

        // CITY AREA 

        [DisplayName("City Area in miles")] 
        [StringLength(4, MinimumLength = 2, ErrorMessage = "Please Enter a Area")]
        public string CityArea { get; set; }

        // STATE

        [DisplayName("State")]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "Please Enter a valid State")]
        public string CityState { get; set; }

        // COUNTRY

        [DisplayName("Country")] 
        [StringLength(24, MinimumLength = 3, ErrorMessage = "Please Enter a valid Country")]
        public string CityCountry { get; set; }

        // Relationships
        public List<Dwelling> Dwellings { get; set; }
    }
}
