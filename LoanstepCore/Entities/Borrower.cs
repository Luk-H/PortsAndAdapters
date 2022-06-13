using LoanstepCore.Emails;

namespace LoanstepCore.Entities;

public class Borrower
{
    public string FirstName { get; }
    public string LastName { get; }
    public EmailAddress EmailAddress { get; }

    public Borrower(string firstName, string lastName, EmailAddress emailAddress)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
    }
}