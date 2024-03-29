﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteMusic.Models;

namespace WebsiteMusic.Controllers
{
    public class LocationController : Controller
    {
        private readonly dbKTVStoreContext _context;
        public LocationController(dbKTVStoreContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
       public ActionResult QuanHuyenList(int LocationId)
        {
            var QuanHuyens = _context.Locations.OrderBy(x => x.LocationId)
                .Where(x => x.ParentCode == LocationId && x.Levels == 2)
                .OrderBy(x => x.Name)
                .ToList();
            return Json(QuanHuyens);
        }
        public ActionResult PhuongXaList (int LocationId)
        {
            var PhuongXas = _context.Locations.OrderBy(x => x.LocationId)
                .Where(x => x.ParentCode == LocationId && x.Levels == 3)
                .OrderBy(x => x.Name)
                .ToList();
            return Json(PhuongXas);
        }
    }
}
