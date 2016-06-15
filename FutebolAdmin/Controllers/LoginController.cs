using FutebolAdmin.BL;
using FutebolAdmin.Helpers;
using FutebolAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FutebolAdmin.Controllers
{
    public class LoginController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            TempData["Imagem"] = Imagem();
        }

        public ActionResult Login()
        {
            return View("Login");
        }

        // GET: /Login/
        [HttpPost]
        public ActionResult Login(Usuario Usuario)
        {
            IUsuarioBO LoginBO = new UsuarioBO();
            try
            {
                ViewBag.UsuarioOuSenhaInvalidos = string.Empty;

                if (LoginBO.ValidarUsuarioLogin(Usuario))
                {
                    FormsAuthentication.SetAuthCookie(Usuario.Login.ToString(), false);
                    return RedirectToAction("Index", "Home", new { u = Seguranca.Criptografar(Usuario.Login) });
                }

                else
                    ViewBag.UsuarioOuSenhaInvalidos = "Usuario e/ou Senha invalidos.";

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("error", ex.Message);
                TempData["mensagem"] = ex.Message;
            }

            return View();
        }

        private string Imagem()
        {
            const string imagens = "12345";

            var valorMax = imagens.Length;
            var random = new Random(DateTime.Now.Millisecond);
            var numero = new StringBuilder(1);

            numero.Append(imagens[random.Next(0, valorMax)]);

            return Url.Content("~/content/images/login/" + numero + ".jpg");
        }
    }
}