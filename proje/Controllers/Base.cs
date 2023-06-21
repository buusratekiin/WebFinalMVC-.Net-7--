using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace proje.Controllers
{
    public class Base : Controller
    {
        public bool IsSessionAlive()
        {
            var value = HttpContext.Session.GetString("UserSession");
            if (value==null)
                return false;
            else
                return true;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (IsSessionAlive() == false )
            {
                TempData["error"] = "Bu sayfayı görüntüleme için giriş yapmalısınız!";
                filterContext.Result = RedirectToAction("Index", "Register");
                return;
            }
            
        }
    }
}
