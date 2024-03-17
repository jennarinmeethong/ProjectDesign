using Microsoft.AspNetCore.Mvc;

namespace ProjectDesign.WebSite.Controllers
{
    [Route("[controller]/[action]")]
    public class MasterDataController : Controller
    {
        public ActionResult DataTypeManagement()
        {
            return View();
        }
        public ActionResult RoleManagement()
        {
            return View();
        }
    }
}
