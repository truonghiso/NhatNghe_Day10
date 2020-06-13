using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NhatNghe_Day09.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}