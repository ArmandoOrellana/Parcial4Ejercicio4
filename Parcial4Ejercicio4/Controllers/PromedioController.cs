using Parcial4Ejercicio4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial4Ejercicio4.Controllers
{
    public class PromedioController : Controller
    {
        // GET: Promedio
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Promedio()
        {
            Datos objModelo = new Datos();
            objModelo.codigo = Request.Form["codigo"].ToString();
            objModelo.nAlumno = Request.Form["nEstudiante"].ToString();
            objModelo.nMateria = Request.Form["nMateria"].ToString();

            objModelo.valor1 = double.Parse(Request.Form["valor1"].ToString());
            objModelo.valor2 = double.Parse(Request.Form["valor2"].ToString());
            objModelo.valor3 = double.Parse(Request.Form["valor3"].ToString());

            objModelo.promedio = (objModelo.valor1 + objModelo.valor2 + objModelo.valor3)/3;
            if (objModelo.promedio <= 4.0)
            {
                objModelo.aprobacion = "Reprobado";
            }
            else
            {
                objModelo.aprobacion = "Aprobado";
            }

            return View("Promedio",objModelo);
        }
    }
}