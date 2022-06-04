using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShopRazorPage.Data;
using EShopRazorPage.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EShopRazorPage.Pages.Category
{
    public class CreateModel : PageModel
    {
        private ApplicationDbContext db;

        [BindProperty]
        public Categories? category { get; set; }

        public CreateModel(ApplicationDbContext _db)
        {
            db = _db;
        }

        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost()
        {
            if (category != null)
            {
                db.Attach(category).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                db.SaveChanges();
            }
            return RedirectToPage("./Index");
        }
    }
}
