using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thegatehousewereham.Database
{
    public interface IPotsAndPotters
    {
        List<Pot> getAllAndyPotsAvailable();
        (List<Pot>, Dictionary<int, string>) getAllAndyPotsAvailableWithMainImage();

        Pot getPotById(int id);
    }
}
