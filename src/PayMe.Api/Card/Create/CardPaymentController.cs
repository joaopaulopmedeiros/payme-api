using Microsoft.AspNetCore.Mvc;

using PayMe.Api.Card.Create.Requests;

namespace PayMe.Api.Card.Controllers;

[ApiController]
[Route("payment")]
public class PaymentsController : ControllerBase
{
    [HttpPost("card")]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<ActionResult> PayAsync([FromBody] CardPaymentRequest request)
    {
        await Task.Yield();
        return Accepted();
    }
}
