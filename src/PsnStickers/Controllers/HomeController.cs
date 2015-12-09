using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using PsnStickers.Models.Response;
using PsnStickers.Tools;
using PsnStickers.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PsnStickers.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new HomeViewModel();
            model.Initialize();
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
