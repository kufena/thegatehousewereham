using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using thegatehousewereham.Models;
using Microsoft.AspNetCore.Session;
using System.Text;
using thegatehousewereham.Baskets;
using thegatehousewereham.Database;

namespace thegatehousewereham.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        BasketContext context;

        public HomeController(ILogger<HomeController> logger, BasketContext basketContext)
        {
            _logger = logger;
            context = basketContext;
        }

        public IActionResult Index()
        {
            int basketid;
            if (this.HttpContext.Session.Keys.Contains<string>("basketid"))
            {
                byte[] bytes;

                this.HttpContext.Session.TryGetValue("basketid", out bytes);
                basketid = BitConverter.ToInt32(bytes, 0);
            }
            else
            {
                BasketManager bm = new BasketManager();
                basketid = bm.createBasketId(context);
                var bytes = BitConverter.GetBytes(basketid);
                this.HttpContext.Session.Set("basketid", bytes);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Pottery()
        {
            return View();
        }

        public IActionResult SoftwareDevelopment()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
