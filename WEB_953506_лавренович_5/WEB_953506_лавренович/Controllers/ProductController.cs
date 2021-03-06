using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953506_лавренович.Entities;
using WEB_953506_лавренович.Models;

namespace WEB_953506_лавренович.Controllers
{
    public class ProductController : Controller
    {
        List<Dish> _dishes;
        List<DishGroup> _dishGroups;
        readonly int _pageSize;
        public ProductController()
        {
            _pageSize = 3;
            SetupData();
        }
        public IActionResult Index(int? group, int pageNo = 1)
        {
            var dishesFiltered = _dishes.Where(d => !group.HasValue || d.DishGroupId == group.Value);
            ViewData["Groups"] = _dishGroups;
            ViewData["CurrentGroup"] = group ?? 0;
            return View(
                ListViewModel<Dish>.GetModel(dishesFiltered, pageNo, _pageSize)
            );
        }
        private void SetupData()
        {
            _dishGroups = new List<DishGroup>{
                new DishGroup {DishGroupId=1, GroupName="Стартеры"},
                new DishGroup {DishGroupId=2, GroupName="Салаты"},
                new DishGroup {DishGroupId=3, GroupName="Супы"},
                new DishGroup {DishGroupId=4, GroupName="Основные блюда"},
                new DishGroup {DishGroupId=5, GroupName="Напитки"},
                new DishGroup {DishGroupId=6, GroupName="Десерты"}
            };
            _dishes = new List<Dish>{
                new Dish {
                    DishId = 1, DishName="Суп-харчо",
                    Description="Название говорит само за себя",
                    Calories=200, DishGroupId=3, Image="Суп.jpg"
                },
                new Dish { 
                    DishId = 2, DishName="Борщ",
                    Description="Более прожаренный харчо",
                    Calories=330, DishGroupId=3, Image="Борщ.jpg" 
                },
                new Dish { 
                    DishId = 3, DishName="Котлета пожарская",
                    Description="Это лотерея, ваши зубы против панировачных сухарей",
                    Calories=635, DishGroupId=4, Image="Котлета.jpg" 
                },
                new Dish { 
                    DishId = 4, DishName="Макароны по-флотски",
                    Description="Да, здесь и правда кусочки белорусского флота",
                    Calories=524, DishGroupId=4, Image="Макароны.jpg" 
                },
                new Dish { 
                    DishId = 5, DishName="Компот",
                    Description="С ионами цезия для повышенной сытности!",
                    Calories=180, DishGroupId=5, Image="Компот.jpg" 
                }
};
        }
    }
}
