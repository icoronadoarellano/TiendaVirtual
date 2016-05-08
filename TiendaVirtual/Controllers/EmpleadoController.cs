using TiendaVirtual.Models;
using TiendaVirtual.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaVirtual.Filtros;
using System.Web.Routing;
using System.Threading;
using System.Globalization;

namespace TiendaVirtual.Controllers
{
    [CustomAuthorize]
    public class EmpleadoController : BaseController
    {
        // GET: Empleado
        //onactionexecuting
        [CustomAuthorize(Roles = "Admin")]
        public ActionResult Registrar()
        {

            //onresultexecuting
            return View();
            //onactionexecuted    
        }

        //onresultexecuted

        [HttpPost]
        [CustomAuthorize(Roles="Admin")]
        public ActionResult Registrar(EmpleadoRegistrar empleado)
        {
            if (ModelState.IsValid)
            {
                var validador = new EmpleadoRegistrarValidator();
                var results = validador.Validate(empleado);
                if (results.IsValid) return RedirectToAction("Index", "Home");
                ModelState.AddModelError("", results.Errors[0].ErrorMessage);
            }
            return View();
        }


        public ActionResult Ver()
        {
            return View(new EmpleadoRegistrar { Nombre = "Alejandro",
                Apellidos = "Coronado",
                Cargo = "Programador",
                Sueldo = 3500,
                Descuentos = 0 });
        }
    }
}