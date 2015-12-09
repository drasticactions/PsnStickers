using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PsnStickers.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PsnStickers.Controllers
{
    public class StickersController : Controller
    {
        // GET: /<controller>/
        public async Task<IActionResult> Index(string id)
        {
            var model = new StickersViewModel();
            await model.Initialize(id);
            return View(model);
        }
    }
}
