using Microsoft.AspNetCore.Mvc;

using PayMe.Api.Card.Requests;

namespace PayMe.Api.Card.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentsController : ControllerBase
{
    [HttpPost("Card")]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<ActionResult> PayAsync([FromBody] CardPaymentRequest request)
    {
        await Task.Yield();
        return Accepted();
    }
}
