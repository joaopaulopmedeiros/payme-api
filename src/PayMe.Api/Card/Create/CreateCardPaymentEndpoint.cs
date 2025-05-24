using PayMe.Api.Card.Create.Requests;

namespace PayMe.Api.Card.Controllers;

public static class CreateCardPaymentEndpoint
{
    public static void MapCreateCardPaymentEndpoint(this WebApplication app)
    {
        app.MapPost("/payment/card", async (CreateCardPaymentRequest request) =>
        {
            await Task.Yield();
            return Results.Accepted();
        })
        .WithTags("Payment")
        .Produces(StatusCodes.Status202Accepted);
    }
}
