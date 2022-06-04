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
    public class DeleteModel : PageModel
    {
        private ApplicationDbContext db;

        [BindProperty]
        public Categories? category { get; set; }

        public DeleteModel(ApplicationDbContext _db)
        {
            db = _db;
        } 

        public ActionResult OnGet(int? id)
        {
            if (id == null)
                return NotFound();

            category = db.Categories.Where(x => x.Id == id).FirstOrDefault();
            if (category == null)
            {
                return NotFound();
            }
            return Page();
        }

        public ActionResult OnPostDelete()
        {
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
