using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Cpt206.SqlServer; // NorthwindContext

namespace CPT206RazorProject.Pages
{
    public class suppliersModel : PageModel
    {
        private NorthwindContext db;
        public IEnumerable<Supplier> Suppliers { get; set; }
        public suppliersModel(NorthwindContext database)
        {
            db = database;
        }
        public void OnGet()//runs when suppliers page is requested with an HTTP GET request
        {
            ViewData["Title"] = "Northwind B2B - Supplers CPT 206";
            Suppliers = db.Suppliers.OrderBy(s => s.Country).ThenBy(s => s.CompanyName);
        }

        //sometime we want user to post or submit to our page
        [BindProperty] //allows associate data that can be submitted 
        public Supplier? Supplier { get; set; }

        public IActionResult OnPost()
        {
            //runs when data, the supplier gets submitted to the page 
            if((Supplier != null) && ModelState.IsValid) 
            {
                db.Suppliers.Add(Supplier); //database add method
                db.SaveChanges(); //save changes to database

                return RedirectToAction("/suppliers"); //we want to reload our page with new info
            }
            else
            {
                //not submit and return our current page
                return Page();
            }
        }
    }
}
