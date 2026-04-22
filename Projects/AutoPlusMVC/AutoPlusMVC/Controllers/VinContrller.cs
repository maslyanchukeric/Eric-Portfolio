using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using AutoPlusMVC.Models;

namespace AutoPlusMVC.Controllers
{
    public class VinController : Controller
    {
        // Used to call external API
        private readonly HttpClient _httpClient;

        public VinController()
        {
            _httpClient = new HttpClient();
        }

        // GET: show empty VIN page
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: handle VIN submission
        [HttpPost]
        public async Task<IActionResult> Index(string vin)
        {
            // Check if VIN is valid (must be 17 chars)
            if (string.IsNullOrWhiteSpace(vin) || vin.Length != 17)
            {
                ViewBag.Error = "VIN must be exactly 17 characters.";
                return View();
            }

            // API URL (NHTSA VIN decoder)
            string url = $"https://vpic.nhtsa.dot.gov/api/vehicles/DecodeVinValues/{vin}?format=json";

            // Call API and get response
            var response = await _httpClient.GetStringAsync(url);

            // Parse JSON response
            using JsonDocument doc = JsonDocument.Parse(response);
            var results = doc.RootElement.GetProperty("Results")[0];

            // Map API data to our model
            var model = new VinResult
            {
                VIN = vin.ToUpper(),
                Make = results.GetProperty("Make").GetString(),
                Model = results.GetProperty("Model").GetString(),
                ModelYear = results.GetProperty("ModelYear").GetString(),
                BodyClass = results.GetProperty("BodyClass").GetString(),
                VehicleType = results.GetProperty("VehicleType").GetString(),
                EngineCylinders = results.GetProperty("EngineCylinders").GetString(),
                FuelTypePrimary = results.GetProperty("FuelTypePrimary").GetString()
            };

            // Send data to view
            return View(model);
        }
    }
}