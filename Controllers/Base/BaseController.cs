using Microsoft.AspNetCore.Mvc;

namespace webapiTercero.Controllers.Base
{
    [ApiController]
    [Route("[Controller]")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]

    public class BaseController : ControllerBase
    {
        
    }
}