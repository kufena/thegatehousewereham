using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thegatehousewereham.Database
{
    public class Pot
    {
        int id;
        int potter_id;
        string name;
        string description;
        string status;

        public Pot(int id, int potter_id, string name, string description, string status)
        {
            this.id = id;
            this.potter_id = potter_id;
            this.name = name;
            this.description = description;
            this.status = status;
        }

        public int Id { get => id; set => id = value; }
        public int Potter_id { get => potter_id; set => potter_id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Status { get => status; set => status = value; }
    }
}
