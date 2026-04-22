using AutoPlusMVC.Data;
using AutoPlusMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class CarsController : Controller
{
    private readonly AppDbContext _context;

    public CarsController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Cars
    public async Task<IActionResult> Index(
       string search,
       string sortOrder,
       int? selectedYear,
       string selectedMake,
       string selectedModel,
       int page = 1)
    {
        int pageSize = 50;

        var carsQuery = _context.Cars.AsQueryable();

        // Search
        if (!string.IsNullOrEmpty(search))
        {
            carsQuery = carsQuery.Where(c =>
                c.Make.Contains(search) ||
                c.Model.Contains(search) ||
                (c.VIN != null && c.VIN.Contains(search)));
        }

        // Filter by Year
        if (selectedYear.HasValue)
        {
            carsQuery = carsQuery.Where(c => c.Year == selectedYear.Value);
        }

        // Filter by Make
        if (!string.IsNullOrEmpty(selectedMake))
        {
            carsQuery = carsQuery.Where(c => c.Make == selectedMake);
        }

        // Filter by Model
        if (!string.IsNullOrEmpty(selectedModel))
        {
            carsQuery = carsQuery.Where(c => c.Model == selectedModel);
        }

        // Sorting
        switch (sortOrder)
        {
            case "price_asc":
                carsQuery = carsQuery.OrderBy(c => c.Price);
                break;

            case "price_desc":
                carsQuery = carsQuery.OrderByDescending(c => c.Price);
                break;

            case "year_asc":
                carsQuery = carsQuery.OrderBy(c => c.Year);
                break;

            case "year_desc":
                carsQuery = carsQuery.OrderByDescending(c => c.Year);
                break;

            default:
                carsQuery = carsQuery.OrderBy(c => c.Make).ThenBy(c => c.Model);
                break;
        }

        int totalCars = await carsQuery.CountAsync();
        int totalPages = (int)Math.Ceiling((double)totalCars / pageSize);

        if (page < 1)
            page = 1;

        if (page > totalPages && totalPages > 0)
            page = totalPages;

        var cars = await carsQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        // Dropdown data
        ViewBag.Years = await _context.Cars
            .Select(c => c.Year)
            .Distinct()
            .OrderBy(y => y)
            .ToListAsync();

        ViewBag.Makes = await _context.Cars
            .Select(c => c.Make)
            .Distinct()
            .OrderBy(m => m)
            .ToListAsync();

        // Model dropdown depends on selected Year + Make
        var modelsQuery = _context.Cars.AsQueryable();

        if (selectedYear.HasValue)
        {
            modelsQuery = modelsQuery.Where(c => c.Year == selectedYear.Value);
        }

        if (!string.IsNullOrEmpty(selectedMake))
        {
            modelsQuery = modelsQuery.Where(c => c.Make == selectedMake);
        }

        ViewBag.Models = await modelsQuery
            .Select(c => c.Model)
            .Distinct()
            .OrderBy(m => m)
            .ToListAsync();

        // Keep selected values
        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = totalPages;
        ViewBag.Search = search;
        ViewBag.SortOrder = sortOrder;
        ViewBag.SelectedYear = selectedYear;
        ViewBag.SelectedMake = selectedMake;
        ViewBag.SelectedModel = selectedModel;

        return View(cars);
    }

    // AJAX: load models instantly when make changes
    [HttpGet]
    public async Task<JsonResult> GetModelsByMake(int? year, string make)
    {
        var modelsQuery = _context.Cars.AsQueryable();

        if (year.HasValue)
        {
            modelsQuery = modelsQuery.Where(c => c.Year == year.Value);
        }

        if (!string.IsNullOrEmpty(make))
        {
            modelsQuery = modelsQuery.Where(c => c.Make == make);
        }
        else
        {
            return Json(new List<string>());
        }

        var models = await modelsQuery
            .Select(c => c.Model)
            .Distinct()
            .OrderBy(m => m)
            .ToListAsync();

        return Json(models);
    }

    // GET: Cars/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var car = await _context.Cars.FirstOrDefaultAsync(m => m.Id == id);

        if (car == null)
        {
            return NotFound();
        }

        return View(car);
    }

    // GET: Cars/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Cars/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Make,Model,Year,Price,VIN,Image")] Car car)
    {
        if (ModelState.IsValid)
        {
            _context.Add(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(car);
    }

    // GET: Cars/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var car = await _context.Cars.FindAsync(id);

        if (car == null)
        {
            return NotFound();
        }

        return View(car);
    }

    // POST: Cars/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Make,Model,Year,Price,VIN,Image")] Car car)
    {
        if (id != car.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(car);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(car.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }

        return View(car);
    }

    // GET: Cars/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var car = await _context.Cars.FirstOrDefaultAsync(m => m.Id == id);

        if (car == null)
        {
            return NotFound();
        }

        return View(car);
    }

    // POST: Cars/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var car = await _context.Cars.FindAsync(id);

        if (car != null)
        {
            _context.Cars.Remove(car);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool CarExists(int id)
    {
        return _context.Cars.Any(e => e.Id == id);
    }
}