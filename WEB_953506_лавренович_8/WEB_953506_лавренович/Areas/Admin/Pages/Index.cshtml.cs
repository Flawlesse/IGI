using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB_953506_лавренович.Data;
using WEB_953506_лавренович.Entities;

namespace WEB_953506_лавренович.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WEB_953506_лавренович.Data.ApplicationDbContext _context;

        public IndexModel(WEB_953506_лавренович.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; }

        public async Task OnGetAsync()
        {
            Dish = await _context.Dishes
                .Include(d => d.Group).ToListAsync();
        }
    }
}
