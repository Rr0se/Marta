using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Pie overview";
            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);


            return View(pies);
        }
    }
}
