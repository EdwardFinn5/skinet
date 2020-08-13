using API.Errors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{   
    [Route("errors/{code}")]
    [ApiExplorerSettings(IgnoreApi = true)]  // added this line so that swagger will ignore this error controller
    public class ErrorController : BaseApiController
    {
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}