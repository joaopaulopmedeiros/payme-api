namespace PayMe.Api.Card.Create.Requests;

public record struct CardPaymentRequest(
    string CardNumber,
    string CardHolderName,
    string ExpirationMonth,
    string ExpirationYear,
    string Cvv,
    decimal Amount,
    string Currency,
    byte Installments,
    string CustomerId,
    string Email,
    string Document
);
