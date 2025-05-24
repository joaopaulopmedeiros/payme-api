using Microsoft.AspNetCore.Mvc;

using PayMe.Api.Card.Create.Requests;

namespace PayMe.Api.Card.Controllers;

[ApiController]
[Route("payment/card")]
[ApiExplorerSettings(GroupName = "card")]
public class CreateCardPaymentController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<ActionResult> HandleAsync([FromBody] CreateCardPaymentRequest request)
    {
        await Task.Yield();
        return Accepted();
    }
}
