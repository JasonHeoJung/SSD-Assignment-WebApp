using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SSD_Assignment_WebApp.Models
{
    public class Industry
    {
        [Display(Name = "Building Name")]
        public string BuildName = "Industry Building";

        [Display(Name = "Building Score")]
        public int BuildScore { get; set; }

        [Display(Name = "Building Position")]
        public string position { get; set; }
    }
}
