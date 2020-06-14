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
        private IScopedService _service3;
        private IScopedService _service4;
        private ISingletonService _service5;

        public Demo1Controller(ItransientService s1, ItransientService s2, IScopedService s3, IScopedService s4, ISingletonService s5)
        {
            _service1 = s1;
            _service2 = s2;
            _service3 = s3;
            _service4 = s4;
            _service5 = s5;

        }

        public IActionResult DemoTransient()
        {
            //var result = $"Service 1: {_service1.GetID()} - Service 2: {_service2.GetID()}";
            //return Content(result);

            ViewBag.Service1 = _service1.GetID();
            ViewBag.Service2 = _service2.GetID();
            ViewBag.Service3 = _service3.GetID();
            ViewBag.Service4 = _service4.GetID();
            ViewBag.Service5 = _service5.GetID();
            return View();
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
