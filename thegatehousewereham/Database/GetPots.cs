using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace thegatehousewereham.Database
{
    public class GetPots
    {
        private readonly string connString;

        private MySqlConnection conn { get; set; }

        public GetPots(MySqlConnection connection)
        {
            conn = connection;
        }

        public List<Pot> getAvailableAndyPots()
        {
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT Pots.Id as id, Pots.Potter as potter, Pots.Name as name, Pots.Description as description, Pots.Status as status " +
                                                        "FROM Pots " +
                                                        "WHERE Pots.Potter = 1 AND Pots.Status = 'available'", conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<Pot> list = new List<Pot>();
                    while (reader.Read())
                    {
                        list.Add(new Pot(Convert.ToInt32(reader.GetUInt32("id")),
                            1,
                            reader.GetString("name"),
                            reader.GetString("description"),
                            reader.GetString("status")));
                    }
                    return list;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        public (List<Pot>, Dictionary<int,string>) getAvailableAndyPotsWithImage()
        {
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT Pots.Id as id, Pots.Potter as potter, Pots.Name as name, Pots.Description as description, Pots.Status as status, PotImages.File as file " +
                                                        "FROM Pots LEFT JOIN PotImages ON (PotImages.PotId = Pots.Id AND PotImages.Type = 'main') " +
                                                        "WHERE Pots.Potter = 1 AND Pots.Status = 'available'", conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<Pot> list = new List<Pot>();
                    Dictionary<int, string> images = new Dictionary<int, string>();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader.GetUInt32("id"));
                        list.Add(new Pot(id,
                            1,
                            reader.GetString("name"),
                            reader.GetString("description"),
                            reader.GetString("status")));
                        if (!reader.IsDBNull(5))
                        {
                            string s = reader.GetString("file");
                            images.Add(id, s);
                        }
                    }
                    return (list, images);
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
