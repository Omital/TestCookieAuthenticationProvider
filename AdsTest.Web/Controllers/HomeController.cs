using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace AdsTest.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AdsTestControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}