using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NhatNghe_Day09.Models;
using NhatNghe_Day09.Models.Service.Interfaces;

namespace NhatNghe_Day09.Controllers
{
    public class Demo1Controller : Controller
    {
        private ItransientService _service1;
        private ItransientService _service2;
        public Demo1Controller(ItransientService s1, ItransientService s2)
        {
            _service1 = s1;
            _service2 = s2;
        }

        public IActionResult DemoTransient()
        {
            var result = $"Service 1: {_service1.GetID()} - Service 2: {_service2.GetID()}";
            return Content(result);
        }

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
