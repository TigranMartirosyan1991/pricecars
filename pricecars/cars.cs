using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricecars
{
    public class cars
    {
        
        public int id { get; set; }
        
        public string model { get; set; }
        public string year { get; set; }
    }
}
