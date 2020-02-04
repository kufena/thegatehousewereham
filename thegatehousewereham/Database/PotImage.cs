using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thegatehousewereham.Database
{
    public class PotImage
    {
        int id;
        int potid;
        string file;

        public PotImage(int id, int potid, string file)
        {
            this.id = id;
            this.potid = potid;
            this.file = file;
        }

        public int Id { get => id; set => id = value; }
        public int Potid { get => potid; set => potid = value; }
        public string File { get => file; set => file = value; }
    }
}
