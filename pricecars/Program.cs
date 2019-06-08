using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricecars
{
    class Program
    {
        static void Main(string[] args)
        {

            context cntxt = new context();
            //cntxt.Database.Log = Console.WriteLine;
            //List<cars> crs = new List<cars>() {
            //    new cars{ id=1,model="BMW",year="2010" },
            //    new cars{ id=2,model="AUDI",year="2008" },
            //    new cars{ id=3,model="OPEL",year="2005" },
            //    new cars{ id=4,model="TOYOTA",year="2018" },
            //    new cars{ id=5,model="RENO",year="2001" },
            //    new cars{ id=6,model="JEEP",year="1999" },
            //};
            //List<Pricecar> prs = new List<Pricecar>() {

            //    new Pricecar{ Id=1,price=18000},
            //    new Pricecar{ Id=1,price=20000},
            //    new Pricecar{ Id=1,price=30000},
            //    new Pricecar{ Id=2,price=1000},
            //    new Pricecar{ Id=2,price=5000},
            //    new Pricecar{ Id=3,price=10000},
            //    new Pricecar{ Id=3,price=10000},
            //    new Pricecar{ Id=4,price=10000},
            //    new Pricecar{ Id=4,price=10000},
            //    new Pricecar{ Id=5,price=10000},
            //    new Pricecar{ Id=5,price=10000},
            //    new Pricecar{ Id=6,price=10000},
            //    new Pricecar{ Id=6,price=10000},

            //};


            //crs.ForEach(Item =>
            //{
            //    cntxt.cars.Add(Item);
            //    cntxt.SaveChanges();

            //});
            //prs.ForEach(Item =>
            //{
            //    cntxt.prices.Add(Item);
            //    cntxt.SaveChanges();

            //});

            List<cars> lstCars = cntxt.cars.ToList();
            List<Pricecar> lstPrice = cntxt.prices.ToList();

            var result = (from a in lstCars
                         join b in lstPrice
      on a.id equals b.Id 
                         select new { md = a.model, yr = a.year, pr = b.price }).ToList();


            foreach (var item in result)
            {

                Console.WriteLine(item.md+"   "+item.yr+"   "+item.pr);
            }
           
            //foreach (vac

            //    Console.WriteLine(Item.model);
            //}
        }
    }
}
