using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thegatehousewereham.Models
{
    public class BasketPots
    {
        int basketId;
        int potId;
        int id;

        public BasketPots(int id, int basketId, int potId)
        {
            this.basketId = basketId;
            this.potId = potId;
        }

        public int Id { get => id; set => id = value; }
        public int BasketId { get => basketId; set => basketId = value; }
        public int PotId { get => potId; set => potId = value;  }
    }
}