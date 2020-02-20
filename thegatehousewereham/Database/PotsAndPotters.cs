using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using thegatehousewereham.Models;

namespace thegatehousewereham.Database
{
    public class PotsAndPotters : IPotsAndPotters
    {
        //private readonly string connString;
        PotterShopContext context;
        public PotsAndPotters(PotterShopContext context)
        {
            this.context = context; // connString = connString;
        }

        public List<Pots> getAllAndyPotsAvailable()
        {
            //MySqlConnection conn = new MySqlConnection(connString);
            GetPots gp = new GetPots(context);
            return gp.getAvailableAndyPots();
        }

        public (List<Pots>, Dictionary<int, string>) getAllAndyPotsAvailableWithMainImage()
        {
            GetPots gp = new GetPots(context);
            return gp.getAvailableAndyPotsWithImage();
        }
        
        public Pots getPotById(int id)
        {
            return (new GetPot(context)).getPotById(id);
        }
    }
}
