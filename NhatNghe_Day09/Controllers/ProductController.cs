using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NhatNghe_Day09.Models;
using NhatNghe_Day09.Models.Service.Interfaces;

namespace NhatNghe_Day09.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductsService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductsService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public IActionResult DemoMapper()
        {
            var sp = new ProductModel
            {
                ProductID = 1,
                ProductName = "Beer",
                Price = 15900,
                Quantity = 1
            };
            var spMap = _mapper.Map<Product>(sp);
            return View(spMap);
        }

        public IActionResult Index()
        {
            var dsHH = _productService.GetAll();
            return View(dsHH);
        }

        public IActionResult Add() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product sp)
        {
            _productService.AddProduct(sp);
            return RedirectToAction("Index");
        }
    }
}