using Microsoft.AspNetCore.Mvc;
using Spin.Base.BaseController;

namespace Spin.Modules.Home.Site.Controllers
{
    public class HomeController : SpinControllerSite
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }
    }
}