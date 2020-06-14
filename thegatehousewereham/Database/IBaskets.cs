using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thegatehousewereham.Models;

namespace thegatehousewereham.Database
{
    public interface IBaskets
    {
        Basket getBasket(int id);
    }
}
