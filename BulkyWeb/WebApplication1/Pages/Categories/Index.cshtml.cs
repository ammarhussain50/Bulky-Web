using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext db;
        public List<Category> CategoriesList { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void OnGet()
        {
            CategoriesList = db.Categories.ToList();
        }
    }
}
