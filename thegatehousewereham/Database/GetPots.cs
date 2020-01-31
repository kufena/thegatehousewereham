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


    }
}
