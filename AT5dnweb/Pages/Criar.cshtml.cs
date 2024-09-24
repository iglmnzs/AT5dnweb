using AT5dnweb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT5dnweb.Pages
{
    public class CriarModel : PageModel
    {    
        [BindProperty]
        public Usuario Usuario { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("Index");
        }
    }
}

