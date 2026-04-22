using AutoPlusMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace AutoPlusMVC.Controllers
{
    public class HomeController : Controller
    {
        // Loads the main home page
        public IActionResult Index()
        {
            return View();
        }

        // Loads the landing page
        public IActionResult Landing()
        {
            return View();
        }

        // Loads the privacy page
        public IActionResult Privacy()
        {
            return View();
        }

        // Handles errors and shows error page
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Sends error info to the view
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }

        [HttpGet]
        public IActionResult VinLookup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> VinLookup(string vin)
        {
            if (string.IsNullOrWhiteSpace(vin) || vin.Length != 17)
            {
                ViewBag.Error = "Invalid VIN";
                return View();
            }

            using (HttpClient client = new HttpClient())
            {
                string url = $"https://vpic.nhtsa.dot.gov/api/vehicles/decodevinvaluesextended/{vin}?format=json";

                var response = await client.GetStringAsync(url);

                using JsonDocument doc = JsonDocument.Parse(response);

                var result = doc.RootElement.GetProperty("Results")[0];

                var vehicle = new VinResult
                {
                    VIN = vin,
                    Make = result.GetProperty("Make").GetString(),
                    Model = result.GetProperty("Model").GetString(),
                    ModelYear = result.GetProperty("ModelYear").GetString(),
                    BodyClass = result.GetProperty("BodyClass").GetString(),
                    VehicleType = result.GetProperty("VehicleType").GetString(),
                    EngineCylinders = result.GetProperty("EngineCylinders").GetString(),
                    FuelTypePrimary = result.GetProperty("FuelTypePrimary").GetString()
                };

                return View(vehicle);
            }
        }
    }
}