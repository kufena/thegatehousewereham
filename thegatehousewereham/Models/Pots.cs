using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thegatehousewereham.Models
{
    public class Pots
    {
        int id;
        int potter_id;
        string name;
        string description;
        string status;

        public Pots(int id, int potterId, string name, string description, string status)
        {
            this.id = id;
            this.potter_id = potterId;
            this.name = name;
            this.description = description;
            this.status = status;
        }

        [Key]
        public int Id { get => id; set => id = value; }
        public int PotterId { get => potter_id; set => potter_id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Status { get => status; set => status = value; }

        public ICollection<PotImages> PotImages { get; set; }
    }
}
