using PayMe.Api.Card.Controllers;

namespace PayMe.Api.Card;

public static class CardEndpoints
{
    public static WebApplication MapCardEndpoints(this WebApplication app)
    {
        app.MapCreateCardPaymentEndpoint();
        return app;
    }
}