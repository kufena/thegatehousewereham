using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thegatehousewereham.Models;

namespace thegatehousewereham.Database
{
    public interface IPotsAndPotters
    {
        List<Pots> getAllAndyPotsAvailable();
        (List<Pots>, Dictionary<int, string>) getAllAndyPotsAvailableWithMainImage();

        Pots getPotById(int id);
    }
}
