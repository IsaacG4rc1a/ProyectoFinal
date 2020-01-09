using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimerAplicacion.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {
            return View();
        }

        public string Mensaje()
        {
            return "Bienvenidos al curos de MVC";
        }

        public string Saludo(string nombre)
        {
            return "Hola, " + nombre + ". ¿Cómo estás?";
        }
    }
}