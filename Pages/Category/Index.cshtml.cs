using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShopRazorPage.Data;
using EShopRazorPage.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EShopRazorPage.Pages
{
    public class CategoryModel : PageModel
    {
        private ApplicationDbContext db;
        public IList<Categories>? Categories { get; set; }

        public CategoryModel (ApplicationDbContext _db)
        {
            db = _db;
        }

        public void OnGet()
        {
            Categories = db.Categories.Select(x => x).OrderBy(x=>x.DisplayOrder).ToList();
        }
    }
}
