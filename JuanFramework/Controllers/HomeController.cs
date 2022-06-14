using JuanFramework.DAL;
using JuanFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JuanFramework.Controllers
{
    public class HomeController : Controller
    {


        private readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
           
            return View();
        }

       
    }
}
