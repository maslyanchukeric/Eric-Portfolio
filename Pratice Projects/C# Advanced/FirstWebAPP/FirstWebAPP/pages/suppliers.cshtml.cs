using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Cpt206.SqlServer;// Importing the NorthwindDemo namespace, which may contain classes related to the Northwind database context


namespace FirstWebAPP.pages
{
    public class suppliersModel : PageModel
    {
        private NorthwindContext db; //creating a private field for the NorthwindDemo database context

        public suppliersModel(NorthwindContext injectedContext) //constructor that takes an injected NorthwindDemo context
        {
                db = injectedContext; //assigning the injected context to the private field
        }
        public IEnumerable<Supplier>? Suppliers { get; set; } //creating a string of suppliers
        public void OnGet() //on get funcion runs when my page loads (formload)
        {
            ViewData["Title"] = "Northwind B2B - Suppliers";
            //LINQ query to get the suppliers from the database, ordered by country and then by company name
            Suppliers = db.Suppliers.OrderBy(c => c.Country).ThenBy(c => c.CompanyName); 
        }
    }
}
