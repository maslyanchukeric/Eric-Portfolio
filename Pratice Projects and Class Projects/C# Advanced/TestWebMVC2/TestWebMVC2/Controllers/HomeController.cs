using Azure.Core;
using Cpt206.SqlServer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.Common;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Reflection.PortableExecutable;
using TestWebMVC2.Models;

namespace TestWebMVC2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindContext db;
        private readonly IHttpClientFactory clientFactory;
        public HomeController(ILogger<HomeController> logger, NorthwindContext _db, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            db = _db; //this is our database
            clientFactory = httpClientFactory;
        }

        public async Task<IActionResult> IndexAsync()
        {
            _logger.LogError("This is an error but not serious");
            _logger.LogWarning("Warning, this is a warning");
            _logger.LogInformation("I am in the index method");

            HomeIndexViewModel model = new
            (
            VisitorCount: (new Random()).Next(1, 1001),
            Categories: db.Categories.ToList(),
            Products: db.Products.ToList()
            );


            try
            {
                HttpClient client = clientFactory.CreateClient("Minimal.WebApi");

                HttpRequestMessage request = new(
                    method: HttpMethod.Get,
                    requestUri: "api/weather");

                HttpResponseMessage response = await client.SendAsync(request);

                ViewData["weather"] = await response.Content.ReadFromJsonAsync<WeatherForecast[]>();
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"The Minimal.WebApi service is not responding. Exception: {ex.Message}");
                ViewData["weather"] = Enumerable.Empty<WeatherForecast>().ToArray();
            }


            return View(model); // pass model to view
        }



        public async Task<IActionResult> Customers(string country)
        {
            string uri;
            if(string.IsNullOrEmpty(country))
            {
                ViewData["Title"] = "All Customers Worldwide";
                uri = "api/customers/";
            }
            else
            {
                ViewData["Title"] = $"Customers in {country}";
                uri = $"api/customers/?country={country}";
            }

            HttpClient client = clientFactory.CreateClient(name: "NorthwindWebApi");

            HttpRequestMessage request = new( method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);

            IEnumerable<Customer>? model = await response.Content.ReadFromJsonAsync<IEnumerable<Customer>>();

            return View(model);

        }

        [Authorize(Roles = "Administrators")]

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ProductDetail(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest("You must pass a product id in the route, for example, /Home/ProductDetails/21");
            }

            //if we do have a value 
            Product? model = db.Products.SingleOrDefault(p => p.ProductId == id);

            if (model == null)
            {
                //no product here
                return NotFound($"Product ID {id} not found");
            }

            return View(model);
        }

        public IActionResult ModelBinding ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ModelBinding(Thing thing)
        {
            return View(thing);
        }

        public IActionResult ProductsCostMoreThan(decimal? price)
        {
            if (!price.HasValue)
            {
                return BadRequest("You must pass a product price in the query string for example, /Home/ProductThatCostMoreThan? price=50");
            }
                
                var model = db.Products.Include(p => p.Category).Include(p => p.Supplier)
                    .Where(p => p.UnitPrice > price);

                if(!model.Any())
                {
                    return NotFound($"No product cost more than {price:C}.");
                }

                ViewData["MaxPrice"] = price.Value.ToString();

                return View(model);
                
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
