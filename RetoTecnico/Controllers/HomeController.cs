using EntidadesCompartidas.Entidades;
using Logica.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using RetoTecnico.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RetoTecnico.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILogicaNave _logicanave;
        static List<Nave> _naves;
        static List<Agencia> _agencias;
        static List<Planeta> _planetas;
        static List<Motor> _motores;
        static List<LanzadorDeEnergia> _lanadores;
        public HomeController(ILogger<HomeController> logger, ILogicaNave logicanave)
        {
            _logger = logger;
            _logicanave = logicanave;
        }

        public IActionResult Index()
        {
            var naves = _logicanave.CantidadDeNavesLanzadas();
            _naves = naves;
            return View(naves);
        }
        public IActionResult Detalles(int numero)
        {
            var _nave = _naves.FirstOrDefault(x => x.Numero == numero);
            return PartialView("_Detalles", _nave);
        }
        public IActionResult ERROR404()
        {
            return PartialView("ERROR404");
        }
        public IActionResult DetallesNT(int numero )
        {
            var _nave = _naves.FirstOrDefault(x => x.Numero == numero);
            return PartialView("_DetallesNT", _nave);
        }

        public IActionResult DetallesV(int numero)
        {
            var _nave = _naves.FirstOrDefault(x => x.Numero == numero);
            return PartialView("_DetallesV", _nave);
        }
        public IActionResult AltaNaveTrip()
        {
            var listagencia = _logicanave.ListadoAgencias();
            _agencias = listagencia;
            SelectList list = new SelectList(listagencia,"Nombre","Nombre");
            ViewBag.ListAgencia = list;
            return View();
        }
        [HttpPost]
        public IActionResult AltaNaveTrip(Tripulada nave)
        {
            try
            {
                if(ModelState.IsValid)
                { 
                var result = _logicanave.AltaNaveTripulada(nave);
                    return PartialView("Congratulations");
                }
                SelectList list = new SelectList(_agencias, "Nombre", "Nombre");
                ViewBag.ListAgencia = list;
                return View(nave);
            }
            catch
            {
                return PartialView("ERROR404");
            }            
        }
        public IActionResult AltaNaveNoTrip()
        {
            var listplaneta = _logicanave.ListadoPlanetas();
            SelectList list1 = new SelectList(listplaneta, "Nombre", "Nombre");
            ViewBag.ListPlaneta = list1;
            _planetas = listplaneta;
            var listagencia = _logicanave.ListadoAgencias();
            SelectList list = new SelectList(listagencia, "Nombre", "Nombre");
            ViewBag.ListAgencia = list;
            _agencias = listagencia;
            var listMotores = _logicanave.ListadoMotores();
            SelectList list2 = new SelectList(listMotores, "CodFabrica", "CodFabrica");
            ViewBag.ListMotor = list2;
            _motores = listMotores;
            return View();
        }

        [HttpPost]
        public IActionResult AltaNaveNoTrip(NoTripulada nave)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _logicanave.AltaNaveNoTripulada(nave);
                    return PartialView("Congratulations");
                }
                SelectList list = new SelectList(_agencias, "Nombre", "Nombre");
                ViewBag.ListAgencia = list;
                SelectList list1 = new SelectList(_planetas, "Nombre", "Nombre");
                ViewBag.ListPlaneta = list1;
               SelectList list2 = new SelectList(_motores, "CodFabrica", "CodFabrica");
                ViewBag.ListMotor = list2;
                return View(nave);
            }
            catch
            {
                return PartialView("ERROR404");
            }

        }
        public IActionResult AltaNaveLanz()
        {
            var listlanzadores = _logicanave.ListadoLanzadores();
            SelectList list1 = new SelectList(listlanzadores, "CodFabrica", "CodFabrica");
            ViewBag.ListLanzadores = list1;
            _lanadores = listlanzadores;
            var listagencia = _logicanave.ListadoAgencias();
            SelectList list = new SelectList(listagencia, "Nombre", "Nombre");
            ViewBag.ListAgencia = list;
            _agencias = listagencia;
            return View();
        }

        [HttpPost]
        public IActionResult AltaNaveLanz(VehiculoLanzadera nave)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _logicanave.AltaNaveLanzadera(nave);
                    return PartialView("Congratulations");
                }
                SelectList list = new SelectList(_agencias, "Nombre", "Nombre");
                ViewBag.ListAgencia = list;
                SelectList list1 = new SelectList(_lanadores, "CodFabrica", "CodFabrica");
                ViewBag.ListLanzadores = list1;
                return View(nave);
            }
            catch
            {
                return PartialView("ERROR404");
            }
        }

        public IActionResult BuscarNave()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BuscarNave(int numero)
        {
            try
            {
                var busqueda = _logicanave.BuscarNave(numero);

                return View(busqueda);
            }
            catch
            {
                return PartialView("ERROR404");
            }
        }
        public IActionResult BuscarNavePlaneta()
        {
            var listplaneta = _logicanave.ListadoPlanetas();
            SelectList list1 = new SelectList(listplaneta, "Nombre", "Nombre");
            ViewBag.ListPlaneta = list1;
            _planetas = listplaneta;
            return PartialView("BuscarNavePlaneta");
        }

        [HttpPost]
        public IActionResult BuscarNavePlaneta(string Nombre)
        {
            try
            {
                var resultado = _logicanave.CantidadDeNavesEnPlaneta(Nombre);
                var listplaneta = _planetas;
                SelectList list1 = new SelectList(listplaneta, "Nombre", "Nombre");
                ViewBag.ListPlaneta = list1;
                return View(resultado);
            }
            catch
            {
                return PartialView("ERROR404");
            }

        }
    }
}
