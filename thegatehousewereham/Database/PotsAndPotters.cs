using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thegatehousewereham.Database
{
    public class PotsAndPotters : IPotsAndPotters
    {
        private readonly string connString;

        public PotsAndPotters(string connString)
        {
            this.connString = connString;
        }
    }
}
