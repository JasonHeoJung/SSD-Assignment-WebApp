using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSD_Assignment_WebApp.Models
{
    public class GridSpace
    {
        public int ycoord { get; set; }

        public int xcoord { get; set; }
        
        public bool Empty { get; set; }

        public char Building { get; set; }
    }
}
