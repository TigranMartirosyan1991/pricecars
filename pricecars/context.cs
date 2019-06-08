using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricecars
{
    public class context:DbContext

    {
        //public context() :base("name=Tiko")
        //{

        //}

        public DbSet<cars> cars { get; set; }
        public DbSet<Pricecar> prices { get; set; }


    }
}
