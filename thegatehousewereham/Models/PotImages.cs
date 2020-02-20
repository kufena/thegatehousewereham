using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thegatehousewereham.Models
{
    public class PotImages
    {
        int id;
        int potsId;
        string file;
        string type;
        int size_x;
        int size_y;

        public PotImages(int id, string file, int size_x, int size_y, int potsId, string type)
        {
            this.id = id;
            this.potsId = potsId;
            this.file = file;
            this.type = type;
            this.size_x = size_x;
            this.size_y = size_y;
        }

        [Key]
        public int Id { get => id; set => id = value; }
        public int PotsId { get => potsId; set => potsId = value; }
        public string File { get => file; set => file = value; }
        public string Type { get => type; set => type = value; }
        public int Size_x { get => size_x; set => size_x = value; }
        public int Size_y { get => size_y; set => size_y = value; }
    }
}
