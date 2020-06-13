using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NhatNghe_Day09.Models;

namespace NhatNghe_Day09.Controllers
{
    public class Demo1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LayDanhMuc()
        {
            var danhMuc = new Demo1
            {
                TenDanhMuc = "Điện Thoại",
                SanPham = new string[] { "Iphone", "SamSung", "LG" }

            };
            return PartialView("_DanhMucdemo1", danhMuc);
        }

        public IActionResult Demo2()
        {
            return View();
        }
    }
}
