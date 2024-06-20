using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class Recommendation
    {
        public string Product_name { get; set; }
        public decimal Price { get; set; }
        public string Contraindications { get; set; }
        public string Brand { get; set; }
        public List<string> Plants { get; set; }
    }
}
