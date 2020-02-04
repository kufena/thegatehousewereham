using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using thegatehousewereham.Database;

namespace thegatehousewereham.Controllers
{
    public class ShopController : Controller
    {
        IPotsAndPotters backEnd;

        public ShopController(IPotsAndPotters pandp)
        {
            this.backEnd = pandp;
        }

        public IActionResult Shop()
        {
            // get the pots and their images, if they have one.
            var (allPots, images) = backEnd.getAllAndyPotsAvailableWithMainImage();

            // zip the pots and images togethers - could have done this above.
            var zip = new Dictionary<int, (Pot, string)>();
            foreach(var pot in allPots)
            {
                string img = null;
                if (images.ContainsKey(pot.Id))
                    img = images[pot.Id];
                zip.Add(pot.Id, (pot, img));
            }

            // Now, make pairs of pots, for the two column display.
            // I still don't think this is the right place for this, but I couldn't get
            // the code to work in the cshtml file.
            // Actually, all of this could become a code block in the cshtml, if we wished.
            List<((Pot, string), (Pot, string))> viewList = new List<((Pot, string), (Pot, string))>();
            (Pot, string) spare = (null,"");
            int i = 0;
            foreach(var pair in zip)
            {
                if (i % 2 == 1)
                {
                    viewList.Add((spare, pair.Value));
                    spare = (null, "");
                }
                else
                {
                    spare = pair.Value; 
                }
                i++;
            }

            if (spare.Item1 != null)
            {
                viewList.Add((spare, (null, "")));
            }
            var v = View();
            v.ViewData["pots"] = viewList;
            return v;
        }

        public IActionResult PotPage(int id)
        {
            var pot = backEnd.getPotById(id);
            var v = View();
            v.ViewData["id"] = id;
            v.ViewData["pot"] = pot;
            return v;
        }
    }
}