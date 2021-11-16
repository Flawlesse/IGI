using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953506_лавренович.Entities;
using WEB_953506_лавренович.Models;
using WEB_953506_лавренович.Extensions;
using WEB_953506_лавренович.Data;
using Microsoft.Extensions.Logging;

namespace WEB_953506_лавренович.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _context;
        readonly int _pageSize;
        public ProductController(ApplicationDbContext context)
        {
            _pageSize = 3;
            _context = context;
        }

        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group, int pageNo = 1)
        {
            var dishesFiltered = _context.Dishes.Where(d => !group.HasValue || d.DishGroupId == group.Value);
            ViewData["Groups"] = _context.DishGroups;
            ViewData["CurrentGroup"] = group ?? 0;
            var model = ListViewModel<Dish>.GetModel(dishesFiltered, pageNo, _pageSize);
            if (Request.IsAjaxRequest())
                return PartialView("_ListPartial", model);
            else
                return View(model);
        }
        
    }
}
