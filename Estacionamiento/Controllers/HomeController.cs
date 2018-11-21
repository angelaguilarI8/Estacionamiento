using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estacionamiento.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                var currentUserId = User.Identity.GetUserId();
                var manager = new UserManager<Estacionamiento.Models.ApplicationUser>(new UserStore<Estacionamiento.Models.ApplicationUser>(new Estacionamiento.Models.ApplicationDbContext()));
                var currentUser = manager.FindById(currentUserId);
                var Rolid = currentUser.RolId;
                ViewBag.rol = Rolid;
                var nom12 = currentUser.Nombre;
                ViewBag.nom = nom12;
                var ape12 = currentUser.Apellido;
                ViewBag.ape = ape12;
            }

           

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Est()
        {

            return View();
        }
        public ActionResult EstacionamientoH()
        {
            return View();
        }
    }
}