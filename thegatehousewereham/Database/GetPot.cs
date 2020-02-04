using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thegatehousewereham.Database
{
    public class GetPot
    {
        private readonly string connString;

        private MySqlConnection conn { get; set; }

        public GetPot(MySqlConnection connection)
        {
            conn = connection;
        }

        public Pot getPotById(int id)
        {
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT Pots.Potter as potter, Pots.Name as name, Pots.Description as description, Pots.Status as status " +
                                                        "FROM Pots " +
                                                        "WHERE Pots.Id=" + id, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Pot p = null;
                    while (reader.Read())
                    {
                        p = new Pot(id,
                            1,
                            reader.GetString("name"),
                            reader.GetString("description"),
                            reader.GetString("status"));
                        break;
                    }
                    return p;
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
