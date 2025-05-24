namespace PayMe.Api.Requests;

public record CardPaymentRequest(
    string CardNumber,
    string CardHolderName,
    string ExpirationMonth,
    string ExpirationYear,
    string Cvv,
    decimal Amount,
    string Currency
);
