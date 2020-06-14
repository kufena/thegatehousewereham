using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thegatehousewereham.Database;

namespace thegatehousewereham.Baskets
{
    public class BasketManager
    {
        public static Random random = new Random(1234);

        public int createBasketId(BasketContext context)
        {
            int newid = random.Next();
            while (checkId(context, newid))
                newid = random.Next();

            context.Baskets.Add(new Models.Basket(newid, DateTime.Now));
            context.SaveChanges();

            return newid;
        }

        public bool checkId(BasketContext context, int id)
        {
            var basket = from row in context.Baskets where row.Id == id select row;
            return basket.Count() > 0;
        }
    }
}
