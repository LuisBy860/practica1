using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica1.Bussines;
using practica1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace practica1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult pratica (Acciones acciones)
        {
            //if (acciones.Dato1 <0|| acciones.Dato2 > 1000000000000)
            //{
            //    return View("error");
            //}

            //Double resultado = acciones.Dato1 + acciones.Dato2;


            //ViewBag.DatoN1V = acciones.Dato1;
            //ViewBag.DatoN2V = acciones.Dato2;
            //ViewBag.VariableAEnviar = resultado;


            //objeto de negocio
            Operaciones op = new Operaciones();
             
            Double resultado = op.pratica(acciones);
            ViewBag.VariableAEnviar = resultado;
            return View();
        }

        public IActionResult resta(Double DatoN1, Double DatoN2)
        {
            
            Double resultado = DatoN1 - DatoN2;
            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.VariableAEnviar = resultado;
            return View();
        }
        public IActionResult multiplicacion(Double DatoN1, Double DatoN2)
        {
            if (DatoN1 < 0 || DatoN2 > 1000000000000)
            {
                return View("error");
            }

            Double resultado = DatoN1 * DatoN2;
            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.VariableAEnviar = resultado;
            return View();
        }
        public IActionResult division(Double DatoN1, Double DatoN2) //estos son query string 
        {
            if (DatoN1 < 0 || DatoN2 > 1000000000000)
            {
                return View("error");
            }
            Double resultado = DatoN1 / DatoN2;
            ViewBag.DatoN1V = DatoN1;
            ViewBag.DatoN2V = DatoN2;
            ViewBag.VariableAEnviar = resultado;


                return View();
              
        }
        public IActionResult error()
        {

            return View();
        }
           

    }
}
