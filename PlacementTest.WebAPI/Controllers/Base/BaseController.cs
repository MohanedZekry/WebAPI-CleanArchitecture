using Microsoft.AspNetCore.Mvc;

namespace PlacementTest.WebAPI.Controllers.Base
{
    [Route("api/[controller]/[Action]")]
    //[Authorize]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
    }
}
