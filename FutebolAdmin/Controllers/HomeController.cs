using FutebolAdmin.BL;
using FutebolAdmin.Helpers;
using FutebolAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FutebolAdmin.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Index/
        public ActionResult Index(string u)
        {
            try
            {
                string _Login = Seguranca.Descriptografar(u);
                if (String.IsNullOrEmpty(_Login))
                    return RedirectToAction("Login", "Login");

                IUsuarioBO LoginBO = new UsuarioBO();
                Usuario _Usuario = LoginBO.DetalharUsuarioByLogin(_Login);
                Session["NomeUsuario"] = _Usuario.Login;

                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();

            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();

            Session.Clear();
            Session.Abandon();

            return RedirectToAction("Login", "Login");
        }
    }
}