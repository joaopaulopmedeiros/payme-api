namespace PayMe.Api.Card.Create.Requests;

public record CreateCardPaymentRequest
{
    public string? CardNumber { get; init; }
    public string? CardHolderName { get; init; }
    public string? ExpirationMonth { get; init; }
    public string? ExpirationYear { get; init; }
    public string? Cvv { get; init; }
    public decimal Amount { get; init; }
    public string? Currency { get; init; }
    public byte Installments { get; init; }
    public string? CustomerId { get; init; }
    public string? Email { get; init; }
    public string? Document { get; init; }
}