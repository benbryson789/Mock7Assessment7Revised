using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mock7BAssessement7Practice.Models
{   
   
    public class Donut
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public string PhotoURL { get; set; }
        public string[] Extras { get; set; }
    }
}
