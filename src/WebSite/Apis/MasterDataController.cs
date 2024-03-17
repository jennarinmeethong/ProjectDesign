using Microsoft.AspNetCore.Mvc;

namespace ProjectDesign.WebSite.Apis
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MasterDataController : ControllerBase
    {
        public IActionResult DataType()
        {
            return Ok();
        }
        public IActionResult Role()
        {
            return Ok();
        }
    }
}
