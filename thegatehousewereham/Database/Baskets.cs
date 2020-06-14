using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thegatehousewereham.Models;

namespace thegatehousewereham.Database
{
    public class Baskets : IBaskets
    {
        BasketContext context;
        public Baskets(BasketContext c)
        {
            this.context = c;
        }

        public Basket getBasket(int id)
        {
            var basketrows = from rows in context.Baskets where rows.Id == id select rows;
            return null;
        }
    }
}
