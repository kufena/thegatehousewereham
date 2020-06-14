using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thegatehousewereham.Models
{
    public class Basket
    {
        int id;
        DateTime touched;

        public int Id { get => id; set => id = value; }
        public DateTime Touched { get => touched; set => touched = value; }

        public Basket(int id, DateTime touched) 
        {
            this.id = id;
        }

    }
}
