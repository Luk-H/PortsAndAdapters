namespace LoanstepCore.Emails;

public class EmailAddress
{
    public string Domain { get; }
    public string Reciver { get; }
    
    public string FullAddress => Reciver + "@" + Domain;

    public EmailAddress(string fullAddress)
    {
        var addressParts = fullAddress.Split($"@");
        Reciver = addressParts[0];
        Domain = addressParts[1];
    }
}