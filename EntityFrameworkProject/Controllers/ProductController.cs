using EntityFrameworkProject.Data;
using EntityFrameworkProject.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
      

      

        public IActionResult Index()
        {
            return View();    
        }


        public async Task<IActionResult> LoadMore(int skip)
        {
            IEnumerable<Product> products = await _context.Products.Where(m => !m.IsDeleted).Include(m=>m.Category).Include(m=>m.ProductImages).Skip(skip).Take(4).ToListAsync();

            return PartialView("_ProductsPartial", products);
        }
    }
}
