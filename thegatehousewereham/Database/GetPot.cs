using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thegatehousewereham.Models;

namespace thegatehousewereham.Database
{
    public class GetPot
    {
        PotterShopContext context;

        public GetPot(PotterShopContext context)
        {
            this.context = context;
        }

        public Pots getPotById(int id)
        {
            var pots = from pot in context.Pots where pot.Id == id select pot;
            return pots.FirstOrDefault();
        }
    }
}
