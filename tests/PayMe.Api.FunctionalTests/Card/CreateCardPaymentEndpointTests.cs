using PayMe.Api.Card.Create.Requests;

namespace PayMe.Api.FunctionalTests.Card;

public class CreateCardPaymentEndpointTests(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
{
    private const string ResourceName = "payment/card";

    [Fact]
    public async Task GivenCorrectParams_WhenSubmitedRequest_ShouldRetrieveResponseWithAcceptedStatusCode()
    {
        HttpClient client = factory.CreateClient();

        Faker<CreateCardPaymentRequest> faker = new Faker<CreateCardPaymentRequest>()
            .RuleFor(x => x.CardNumber, f => "4111111111111111")
            .RuleFor(x => x.CardHolderName, f => f.Name.FullName())
            .RuleFor(x => x.ExpirationMonth, f => f.Date.Future().Month.ToString("D2"))
            .RuleFor(x => x.ExpirationYear, f => f.Date.Future().Year.ToString())
            .RuleFor(x => x.Cvv, f => f.Finance.CreditCardCvv())
            .RuleFor(x => x.Amount, f => f.Finance.Amount(10, 500))
            .RuleFor(x => x.Currency, f => "BRL")
            .RuleFor(x => x.Installments, f => (byte)f.Random.Int(1, 12))
            .RuleFor(x => x.CustomerId, f => $"c_{f.Random.AlphaNumeric(6)}")
            .RuleFor(x => x.Email, f => f.Internet.Email())
            .RuleFor(x => x.Document, f => f.Random.ReplaceNumbers("###########"));

        CreateCardPaymentRequest request = faker.Generate();

        HttpResponseMessage response = await client.PostAsJsonAsync(ResourceName, request);

        Assert.Equal(HttpStatusCode.Accepted, response.StatusCode);
    }
}