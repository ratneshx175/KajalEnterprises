using KajalEnterprises.Data;
using KajalEnterprises.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KajalEnterprises.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDBContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(int? categoryId)
        {
            var categories = _db.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            List<Product> productList;
            if (categoryId.HasValue && categoryId.Value > 0)
            {
                productList = _db.Products
                    .Include(p => p.Category)
                    .Where(p => p.CategoryId == categoryId.Value)
                    .ToList();
            }
            else
            {
                productList = _db.Products
                    .Include(p => p.Category)
                    .ToList();
            }

            return View(productList);
        }


        public IActionResult Details(int id)
        {
            var product = _db.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
