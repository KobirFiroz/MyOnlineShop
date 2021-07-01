using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Data;
using MyOnlineShop.Models;

namespace MyOnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductCategoryController : Controller
    {
        private ApplicationDbContext _db;

        public ProductCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            // var data = _db.ProductTypes.ToList();
            return View(_db.ProductTypes.ToList());
        }

        //Create Get Action Method
        public ActionResult Create()
        {
            return View();
        }

        //Create Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.ProductTypes.Add(productTypes);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productTypes);
        }
    }
 }




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using MyOnlineShop.Data;
//using MyOnlineShop.Models;

//namespace MyOnlineShop.Areas.Admin.Controllers
//{
   
//    public class ProductTypesController : Controller
//    {


        

//    }
//}