using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using EventSoucing.Repositories.Ship.Domain;
using EventSourcing.Enums.Data;
using Microsoft.AspNetCore.Mvc;
using EventSourcing.Models;
using EventSourcing.Models.Data;
using EventSourcing.Models.Products;

namespace EventSourcing.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShipRepository _shipRepository;

        public HomeController(IShipRepository shipRepository)
        {
            _shipRepository = shipRepository;
        }

        public async Task<IActionResult> Index()
        {
            var ships = await _shipRepository.GetListShip();

            return View(ships);
        }
    }
}
