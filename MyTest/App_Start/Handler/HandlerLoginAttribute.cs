using Code;
using System.Web.Mvc;

namespace MyTest.Web
{
    public class HandlerLoginAttribute : AuthorizeAttribute
    {
        public bool Ignore = true;
        public HandlerLoginAttribute(bool ignore = true)
        {
            Ignore = ignore;
        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (Ignore == false)
            {
                return;
            }
            if (OperatorProvider.Provider.GetCurrent() == null)
            {
                WebHelper.WriteCookie("_login_error", "overdue");
                filterContext.Result = new RedirectResult("/Admin/Login/Index");
                return;
            }
        }
    }
}