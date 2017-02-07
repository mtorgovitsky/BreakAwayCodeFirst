using BreakAwayCodeFirst.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakAwayCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new MyEnitiesDB())
            {
                Customer c1 = ctx.Customers.FirstOrDefault();
            }
        }
    }
}
