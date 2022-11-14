using Microsoft.AspNetCore.Mvc;

namespace ApiBasics.Controllers
{
    public class StatusController: ControllerBase
    {
        [HttpGet("/status")]
        public ActionResult GetTheStatus()
        {
            return Ok("Everything looks good");
        }
    }
}
