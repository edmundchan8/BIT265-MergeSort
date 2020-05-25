using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using BIT265_MergeSort.Models;
using System.Security.Cryptography.X509Certificates;
using BIT265_MergeSort.Services;

namespace BIT265_MergeSort.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _dbc;

        private readonly ILogger<HomeController> _logger;
        private IMergeSortServices mergeSortServices;

        public HomeController(ILogger<HomeController> logger, IMergeSortServices ms, AppDbContext dbc)
        {
            _logger = logger;
            mergeSortServices = ms;
            _dbc = dbc;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();
            return View(ivm);
        }

        [HttpPost]
        public IActionResult Index(IndexViewModel ivm)
        {
            if (ModelState.IsValid)
            {
                if (ivm.WifiHours != null)
                {
                    var wifi = _dbc.WifiHotposts.Where(w => w.City == "EVERETT"));
                    wifi = mergeSortServices.MergeSort(_dbc.WifiHotposts);
                    return RedirectToAction("Result", dm);
                }
            }
            else
                    return View();
        }

        [HttpGet]
        public IActionResult Result(DataModel dm)
        {
                return View(dm.result);
        }

        public IActionResult Privacy()
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
