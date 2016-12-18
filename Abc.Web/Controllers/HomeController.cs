using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.DAL.Models;

namespace Abc.Web.Controllers
{
    public class HomeController : Controller
    {
        private AbcDatabaseContext _context;

        public HomeController(AbcDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var productList = from prod in _context.Product
                              join prodtype in _context.ProductType
                              on prod.ProductTypeId equals prodtype.ProductTypeId
                              select 
                              new {
                                  idProd = prod.ProductId,
                                  nameProd = prod.Name,
                                  idProdType = prodtype.ProductTypeId,
                                  prodName = prodtype.Name
                              };
            

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
