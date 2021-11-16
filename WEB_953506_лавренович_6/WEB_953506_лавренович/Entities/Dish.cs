using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953506_лавренович.Entities
{
    public class Dish
    {
        public int DishId { get; set; } 
        public string DishName { get; set; } // название 
        public string Description { get; set; } // описание 
        public int Calories { get; set; } // кол. калорий 
        public string Image { get; set; } // имя файла изображения
        public int DishGroupId { get; set; }
        public DishGroup Group { get; set; }
    }
    public class DishGroup
    {
        public int DishGroupId { get; set; }
        public string GroupName { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}
