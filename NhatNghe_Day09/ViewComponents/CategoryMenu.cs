using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NhatNghe_Day09.Models.Service.Interfaces;

namespace NhatNghe_Day09.ViewComponents
{
    public class CategoryMenu : ViewComponent
    {
        private readonly IProductsService _services;
        public CategoryMenu(IProductsService services)
        {
            _services = services;
        }
        public IViewComponentResult Invoke()
        {
            return View("Default", _services.GetAll());
        }
    }
}
