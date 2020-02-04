using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace thegatehousewereham.Database
{
    public class PotsAndPotters : IPotsAndPotters
    {
        private readonly string connString;

        public PotsAndPotters(string connString)
        {
            this.connString = connString;
        }

        public List<Pot> getAllAndyPotsAvailable()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            GetPots gp = new GetPots(conn);
            return gp.getAvailableAndyPots();
        }

        public (List<Pot>, Dictionary<int, string>) getAllAndyPotsAvailableWithMainImage()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            GetPots gp = new GetPots(conn);
            return gp.getAvailableAndyPotsWithImage();
        }
        
        public Pot getPotById(int id)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            return (new GetPot(conn)).getPotById(id);
        }
    }
}
