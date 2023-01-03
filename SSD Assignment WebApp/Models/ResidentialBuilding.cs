using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace SSD_Assignment_WebApp.Models
{
    public class ResidentialBuilding
    {
        [Display(Name = "Building Name")]
        public string BuildName = "Residential Building";

        [Display(Name = "Building Score")]
        public int BuildScore { get; set; }

        [Display(Name = "Building Position")]
        public string position { get; set; }
    }
}
