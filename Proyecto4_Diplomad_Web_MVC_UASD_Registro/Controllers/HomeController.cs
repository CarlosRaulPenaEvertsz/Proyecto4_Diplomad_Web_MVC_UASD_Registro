using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto4_Diplomad_Web_MVC_UASD_Registro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FormularioVisita()
        {
            return View();
        }
        public ActionResult CargaDatos()
        {
            string nombre = Request.Form["nombre"].ToString();
            string comentarios = Request.Form["comentarios"].ToString();
            Proyecto4_Diplomad_Web_MVC_UASD_Registro.Models.LibroVisitas libro = new Proyecto4_Diplomad_Web_MVC_UASD_Registro.Models.LibroVisitas();
            libro.Grabar(nombre, comentarios);
            return View();
        }
        public ActionResult ListadoVisitas()
        {
            Proyecto4_Diplomad_Web_MVC_UASD_Registro.Models.LibroVisitas libro = new Proyecto4_Diplomad_Web_MVC_UASD_Registro.Models.LibroVisitas();
            string todo = libro.Leer();
            ViewData["libro"] = todo;
            return View();
        }
    }
}