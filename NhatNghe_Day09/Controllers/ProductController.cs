using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NhatNghe_Day09.Models;
using NhatNghe_Day09.Models.Service.Interfaces;

namespace NhatNghe_Day09.Controllers
{
    public class ProductController : Controller
    {
        private IProductsService _productService;

        public ProductController(IProductsService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var dsHH = _productService.GetAll();
            return View();
        }
    }
}