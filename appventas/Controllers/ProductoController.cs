using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appventas.Models;

namespace appventas.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;

        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "";
            return View();
        }
[HttpPost]
        public IActionResult Create(Producto objProducto)
        {
            Double total = 0.0;
            total = (objProducto.Precio * objProducto.Cantidad) * 1.18;
            ViewData["Message"] = "El total es: S/." + total + " (Incluye IGV)";
            return View("Index");
        }
    }
}
