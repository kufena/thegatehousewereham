using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using thegatehousewereham.Models;

namespace thegatehousewereham.Database
{
    public class GetPots
    {

        //private MySqlConnection conn { get; set; }
        PotterShopContext context;

        public GetPots(PotterShopContext context) //MySqlConnection connection)
        {
            //conn = connection;
            this.context = context;
        }

        public List<Pots> getAvailableAndyPots()
        {
            var pots = from pot in context.Pots where pot.Status == "available" select pot;
                
            List<Pots> list = new List<Pots>();
            foreach (var pot in pots)
                list.Add(pot);
            return list;
        }

        public (List<Pots>, Dictionary<int,string>) getAvailableAndyPotsWithImage()
        {
                //MySqlCommand command = new MySqlCommand("SELECT Pots.Id as id, Pots.Potter as potter, Pots.Name as name, Pots.Description as description, Pots.Status as status, PotImages.File as file " +
                //                                        "FROM Pots LEFT JOIN PotImages ON (PotImages.PotId = Pots.Id AND PotImages.Type = 'main') " +
                //                                        "WHERE Pots.Potter = 1 AND Pots.Status = 'available'", conn);

            var potswithimages = from pot in context.Pots
                                    where pot.Status == "available"
                                    join image in context.PotImages on pot.Id equals image.PotsId into gj
                                    from subimage in gj.DefaultIfEmpty()
                                    where subimage == null || subimage.Type == "main"
                                    select new { pot, subimage.File };

            List<Pots> list = new List<Pots>();
            Dictionary<int, string> images = new Dictionary<int, string>();
            foreach (var entry in potswithimages)
            {
                list.Add(entry.pot);
                images.Add(entry.pot.Id, entry.File);
            }
            return (list, images);
        }
    }
}
